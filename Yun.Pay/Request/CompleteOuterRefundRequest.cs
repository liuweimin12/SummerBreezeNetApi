using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 完成外部退款
    /// yun.pay.outerrefund.complete
    /// </summary>
    public class CompleteOuterRefundRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 外部退款记录ID
        /// </summary>
        public int OuterRefundId { get; set; }

        public string GetApiName()
        {
            return "yun.pay.outerrefund.complete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"outerrefundid", OuterRefundId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("outerrefundid", OuterRefundId, 1);
        }
    }
}
