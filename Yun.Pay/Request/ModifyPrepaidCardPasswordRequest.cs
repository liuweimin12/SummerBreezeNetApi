using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class ModifyPrepaidCardPasswordRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardId { get; set; }

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
            return "chenggou.prepaidcard.password.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardid", PrepaidCardId},
                {"cardpassword", TopUtils.EncryptAes(CardPassword, AppSecret)}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("prepaidcardid", PrepaidCardId);
            RequestValidator.ValidateRequired("cardpassword", CardPassword);
        }
    }
}
