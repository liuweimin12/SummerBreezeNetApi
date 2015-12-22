using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取单条退款详情
    /// </summary>
    public class GetRefundDetailRequest : ITopRequest<GetRefundDetailResponse>
    {
         /// <summary>
        /// 退款号
        /// </summary>
        public int RefundId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public int OrderId { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.refund.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"refundid",RefundId},
                {"orderid",OrderId}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
