using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取订单详情
    /// 根据订单ID获取订单详情
    /// </summary>
    public class GetTradeRequest : ITopRequest<NormalTradeResponse>
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 交易号（pay_id）
        /// </summary>
        public string TradeNo { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"tradeno",TradeNo}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
