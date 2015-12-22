using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 确认收货
    /// chenggou.trade.confirm
    /// </summary>
    public class ConfirmTradeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int TradeId { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.confirm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeid",TradeId}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tradeid", TradeId);
            RequestValidator.ValidateMinValue("tradeid", TradeId, 1);
        }
    }
}
