using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 使用充值卡进行账户登录
    /// </summary>
    public class UsePrepaidCardRegisterRequest : ITopRequest<LoginResponse>
    {
        /// <summary>
        /// 充值卡卡号
        /// </summary>
        public string CardNumber { get; set; }


        /// <summary>
        /// 充值卡密码
        /// </summary>
        public string CardPassword { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }


        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.login";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cardnumber", CardNumber},
                {"cardpassword", TopUtils.EncryptAes(CardPassword, AppSecret)},
                {"ip", this.Ip}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("username", this.CardNumber);
            RequestValidator.ValidateRequired("password", this.CardPassword);
            RequestValidator.ValidateRequired("ip", this.Ip);
            RequestValidator.ValidateRequired("appsecret", this.AppSecret);
        }
    }
}
