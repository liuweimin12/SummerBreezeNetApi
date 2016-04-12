using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    /// <summary>
    /// 短信发送
    /// 根据指定的通道发送短信
    /// chenggou.sms.send
    /// </summary>
    public class SendShortMessageRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 目标的手机号码
        /// </summary>
        public string Mobile { get; set; }


        /// <summary>
        /// 短信内容
        /// </summary>
        public string Content { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"mobile",Mobile},
                {"content",Content},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
