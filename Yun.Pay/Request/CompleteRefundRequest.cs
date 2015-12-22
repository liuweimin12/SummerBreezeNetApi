using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 完成资金流的退款请求
    /// </summary>
    public class CompleteRefundRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 退款ID
        /// </summary>
        public long RefundId { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.refund.complete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"refundid", RefundId}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
