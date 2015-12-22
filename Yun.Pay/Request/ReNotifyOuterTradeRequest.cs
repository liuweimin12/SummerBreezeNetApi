using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 再次通知外部订单
    /// chenggou.pay.outertrade.renotify
    /// </summary>
    public class ReNotifyOuterTradeRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 现金流的ID
        /// </summary>
        public long FlowId { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.outertrade.renotify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"flowid",FlowId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
