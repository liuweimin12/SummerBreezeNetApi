using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using Jayrock.Json.Conversion;
using Yun.Interface;
using Yun.Parser;
using Yun.Response;
using Yun.Util;

namespace Yun
{
    /// <summary>
    /// 基于REST的TOP客户端。
    /// </summary>
    public class DefaultYunClient : IYunClient
    {
        public const string APP_KEY = "app_key";
        public const string FORMAT = "format";
        public const string METHOD = "method";
        public const string TIMESTAMP = "timestamp";
        public const string VERSION = "v";
        public const string SIGN = "sign";
        public const string SESSION = "session";
        public const string FORMAT_XML = "xml";

        private string serverUrl;
        private string appKey;
        private string appSecret;
        private string format = "xml";

        private WebUtils webUtils;
        private IYunLogger topLogger;
        private bool disableParser = false; // 禁用响应结果解释
        private bool disableTrace = true; // 禁用日志调试功能
        private IDictionary<string, string> systemParameters; // 设置所有请求共享的系统级参数

        public static long ToUnix(DateTime dt)
        {
            DateTime unixStartTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan timeSpan = dt.Subtract(unixStartTime);
            return timeSpan.Ticks / 10000000;
        }  

        #region DefaultTopClient Constructors

        public DefaultYunClient(string serverUrl, string appKey, string appSecret)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
            this.topLogger = new DefaultYunLogger();
        }

        public DefaultYunClient(string serverUrl, string appKey, string appSecret, string format)
            : this(serverUrl, appKey, appSecret)
        {
            this.format = format;
        }

        #endregion


        public void SetTopLogger(IYunLogger topLogger)
        {
            this.topLogger = topLogger;
        }

        public void SetTimeout(int timeout)
        {
            this.webUtils.Timeout = timeout;
        }

        public void SetDisableParser(bool disableParser)
        {
            this.disableParser = disableParser;
        }

        public void SetDisableTrace(bool disableTrace)
        {
            this.disableTrace = disableTrace;
        }

        public void SetSystemParameters(IDictionary<string, string> systemParameters)
        {
            this.systemParameters = systemParameters;
        }

        #region ITopClient Members

        public static T JsonDeserialize<T>(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
                return default(T);

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                var ser = new DataContractJsonSerializer(typeof(T));
                return (T)ser.ReadObject(ms);
            }
        }

        public T Execute<T>(ITopRequest<T> request) where T : YunResponse
        {
            return Execute<T>(request, null);
        }

        public T Execute<T>(ITopRequest<T> request, string session) where T : YunResponse
        {
            return Execute<T>(request, session, ToUnix(DateTime.Now));
        }

        public T Execute<T>(ITopRequest<T> request, string session, long timestamp) where T : YunResponse
        {
            return DoExecute<T>(request, session, timestamp);
        }

        #endregion

        private T DoExecute<T>(ITopRequest<T> request, string session, long timestamp) where T : YunResponse
        {
            // 提前检查业务参数
            try
            {
                request.Validate();
            }
            catch (YunException e)
            {
                return CreateErrorResponse<T>(e.ErrorCode, e.ErrorMsg);
            }

            // 添加协议级请求参数
            var txtParams = new YunDictionary(request.GetParameters())
            {
                {METHOD, request.GetApiName()},
                {VERSION, "1.0"},
                {APP_KEY, appKey},
                {FORMAT, format},
                {TIMESTAMP, timestamp},
                {SESSION, session}
            };
            txtParams.AddAll(this.systemParameters);

            // 添加签名参数
            txtParams.Add(SIGN, TopUtils.SignTopRequest(txtParams, appSecret,"UTF-8"));

            var reqUrl = webUtils.BuildGetUrl(this.serverUrl, txtParams);
            try
            {
                string body;
                if (request is ITopUploadRequest<T>) // 是否需要上传文件
                {
                    var uRequest = (ITopUploadRequest<T>)request;
                    var fileParams = TopUtils.CleanupDictionary(uRequest.GetFileParameters());
                    body = webUtils.DoPost(this.serverUrl, txtParams, fileParams);
                }
                else
                {
                    body = webUtils.DoPost(this.serverUrl, txtParams);
                }

                // 解释响应结果
                T rsp;
                if (disableParser)
                {
                    rsp = Activator.CreateInstance<T>();
                    rsp.Body = body;
                }
                else
                {
                    if (FORMAT_XML.Equals(format))
                    {
                        ITopParser tp = new TopXmlParser();
                        rsp = tp.Parse<T>(body);
                    }
                    else
                    {
                        ITopParser tp = new TopJsonParser();
                        rsp = tp.Parse<T>(body);
                        //rsp = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(body);
                        //rsp = JsonDeserialize<T>(body);
                    }
                }

                rsp.ReqUrl = reqUrl;

                // 追踪错误的请求
                if (!disableTrace && rsp.IsError)
                {
                    var sb = new StringBuilder(reqUrl).Append(" response error!\r\n").Append(rsp.Body);
                    topLogger.Warn(sb.ToString());
                }
                return rsp;
            }
            catch (Exception e)
            {
                if (!disableTrace)
                {
                    var sb = new StringBuilder(reqUrl).Append(" request error!\r\n").Append(e.StackTrace);
                    topLogger.Error(sb.ToString());
                }
                throw e;
            }
        }

        private T CreateErrorResponse<T>(string errCode, string errMsg) where T : YunResponse
        {
            var rsp = Activator.CreateInstance<T>();
            rsp.ErrCode = errCode;
            rsp.ErrMsg = errMsg;

            if (FORMAT_XML.Equals(format))
            {
                var root = new XmlDocument();
                var bodyE = root.CreateElement("error_response");
                var codeE = root.CreateElement("code");
                codeE.InnerText = errCode;
                bodyE.AppendChild(codeE);
                var msgE = root.CreateElement("msg");
                msgE.InnerText = errMsg;
                bodyE.AppendChild(msgE);
                root.AppendChild(bodyE);
                rsp.Body = root.OuterXml;
            }
            else
            {
                IDictionary<string, object> errObj = new Dictionary<string, object>();
                errObj.Add("code", errCode);
                errObj.Add("msg", errMsg);
                IDictionary<string, object> root = new Dictionary<string, object>();
                root.Add("error_response", errObj);

                var body = JsonConvert.ExportToString(root);
                rsp.Body = body;
            }
            return rsp;
        }

    }
}
