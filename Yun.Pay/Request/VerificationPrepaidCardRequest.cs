using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 检测充值卡是否正确，正确则返回卡信息
    /// </summary>
    public class VerificationPrepaidCardRequest : ITopRequest<GetPrepaidCardDetailResponse>
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// 卡密码
        /// </summary>
        public string CardPassword { get; set; }


        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.validate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cardnumber",CardNumber},
                {"cardpassword",TopUtils.EncryptAes(CardPassword, AppSecret)}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cardnumber", this.CardNumber);
            RequestValidator.ValidateRequired("cardpassword", this.CardPassword);
            RequestValidator.ValidateRequired("appsecret", this.AppSecret);
        }
    }
}
