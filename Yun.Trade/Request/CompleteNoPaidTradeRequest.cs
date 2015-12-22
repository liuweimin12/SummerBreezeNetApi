using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{   
    /// <summary>
    /// 完成实际付款为0的订单
    /// chenggou.trade.nopaid.complete
    /// </summary>
    public class CompleteNoPaidTradeRequest : ITopRequest<BoolResultResponse>
    {

        public string GetApiName()
        {
            return "chenggou.trade.nopaid.complete";
        }

        /// <summary>
        /// 订单ID
        /// </summary>
        public int TradeId { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeid", TradeId}
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
