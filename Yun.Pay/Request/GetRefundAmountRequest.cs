using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取可退款金额
    /// yun.payment.refundamount.get
    /// </summary>
    public class GetRefundAmountRequest : ITopRequest<GetRefundAmountResponse>
    {
        /// <summary>
        /// 获取外部交易号
        /// </summary>
        public string OutTradeNum { get; set; }

        public string GetApiName()
        {
            return "yun.payment.refundamount.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"outtradenum", OutTradeNum}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("outtradenum", OutTradeNum);
        }
    }
}
