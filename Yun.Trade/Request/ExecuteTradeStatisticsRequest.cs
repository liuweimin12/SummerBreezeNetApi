using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 人为执行订单数据统计
    /// chenggou.trade.statistics.execute
    /// </summary>
    public class ExecuteTradeStatisticsRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 统计多少天前的订单数据，不能统计当天的
        /// </summary>
        public int Day { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.statistics.execute";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"day", Day}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("day", Day);
            RequestValidator.ValidateMinValue("day", Day, 1);
        }
    }
}
