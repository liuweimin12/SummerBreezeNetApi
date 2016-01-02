using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class LoginRequest : ITopRequest<LoginResponse>
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

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 忽略密码
        /// </summary>
        public bool IgnorePassword { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.login";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"username", this.UserName},
                {"password", string.IsNullOrWhiteSpace(Password) ? "" : TopUtils.EncryptAes(Password, AppSecret)},
                {"ip", this.Ip},
                {"ignorepassword", IgnorePassword}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("username", this.UserName);
            RequestValidator.ValidateRequired("appsecret", this.AppSecret);
        }

    }
}
