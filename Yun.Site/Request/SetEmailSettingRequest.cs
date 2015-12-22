using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 保存邮件发送配置信息
    /// </summary>
    public class SetEmailSettingRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// SMTP主机
        /// </summary>
        public string Server { get; set; }


        /// <summary>
        /// 端口
        /// </summary>
        public int Port { get; set; }


        /// <summary>
        /// 是否使用SSL 
        /// </summary>
        public int Ssl { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 发信地址
        /// </summary>
        public string From { get; set; }

        public string GetApiName()
        {
            return "chenggou.email.setting.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"server", Server},
                {"port",Port},
                {"ssl",Ssl},
                {"username",UserName},
                {"password",Password},
                {"from",From}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("server", Server);
            RequestValidator.ValidateRequired("from", From);
            RequestValidator.ValidateRequired("password", Password);
            RequestValidator.ValidateRequired("username", UserName);
            RequestValidator.ValidateRequired("port", Port);
            RequestValidator.ValidateRequired("ssl", Ssl);
        }
    }
}
