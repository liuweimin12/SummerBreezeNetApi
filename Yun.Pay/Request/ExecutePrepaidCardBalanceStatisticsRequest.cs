using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 统计店铺下充值卡余额
    /// chenggou.pay.prepaidcard.statistics.shopbalance.execute
    /// </summary>
    public class ExecutePrepaidCardBalanceStatisticsRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.pay.prepaidcard.statistics.shopbalance.execute";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
