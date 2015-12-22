using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class CompletePayRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 支付流水ID 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNum { get; set; }

        /// <summary>
        /// 支付密码
        /// </summary>
        public string PayPassword { get; set; }

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.complete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"overmoney", OutTradeNum},
                {"password", TopUtils.EncryptAes(PayPassword, AppSecret)},
            };
            return parameters;
        }

        public void Validate()
        {
           
        }
    }
}
