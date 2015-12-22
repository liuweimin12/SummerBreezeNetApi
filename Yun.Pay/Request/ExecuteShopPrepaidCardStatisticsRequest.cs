using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 人工执行充值卡按店铺统计
    /// chenggou.pay.prepaidcard.statistics.shop.execute
    /// </summary>
    public class ExecuteShopPrepaidCardStatisticsRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 统计多少天前的订单数据，不能统计当天的
        /// </summary>
        public int Day { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.prepaidcard.statistics.shop.execute";
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
