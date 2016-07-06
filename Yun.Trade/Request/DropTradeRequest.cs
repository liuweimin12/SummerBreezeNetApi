using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 丢弃订单，丢弃订单号，买家也会看不到该订单
    /// yun.trade.drop
    /// </summary>
    public class DropTradeRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public int TradeId { get; set; }

        /// <summary>
        /// 关闭理由
        /// </summary>
        public string DropReason { get; set; }

        public string GetApiName()
        {
            return "yun.trade.drop";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeid", TradeId},
                {"dropreason", DropReason}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tradeid", TradeId);
            RequestValidator.ValidateRequired("dropreason", DropReason);
        }
    }
}
