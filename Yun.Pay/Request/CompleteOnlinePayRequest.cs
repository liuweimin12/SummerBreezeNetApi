using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 完成在线付款，该方法一般用于在线付款的测试
    /// </summary>
    public class CompleteOnlinePayRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 支付密码
        /// </summary>
        public string PayPassword { get; set; }

        /// <summary>
        /// 支付流水ID 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 在线支付的金额
        /// </summary>
        public double Money { get; set; }


        /// <summary>
        /// 第三方机构的交易号
        /// </summary>
        public string TradeNum { get; set; }

        public string GetApiName()
        {
            return "chenggou.onlinepay.complete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"money", Money},
                {"tradenum", TradeNum},
                {"paypassword",PayPassword}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("money", Money);
            RequestValidator.ValidateMinValue("money", Money, 0.01);
            RequestValidator.ValidateRequired("tradenum", TradeNum);
        }
    }
}
