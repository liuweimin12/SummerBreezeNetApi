using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Private.Response;
using Yun.Util;

namespace Yun.Private.Request
{
    /// <summary>
    /// 云商管理员登录
    /// chenggou.yun.sitemaster.login
    /// </summary>
    public class SiteMasterLoginRequest : ITopRequest<LoginResponse>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 经过加密的密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户的IP地址
        /// </summary>
        public string Ip { get; set; }

        public string AppSecret { get; set; }

        public string GetApiName()
        {
            return "chenggou.yun.sitemaster.login";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"username", this.UserName},
                {"password", TopUtils.EncryptAes(Password, AppSecret)},
                {"ip", this.Ip}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("username", UserName);
            RequestValidator.ValidateRequired("password", Password);
        }
    }
}
