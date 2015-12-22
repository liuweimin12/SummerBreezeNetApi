using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Trade.Request
{   
    /// <summary>
    /// 批量确认收货
    /// chenggou.trade.batch.confirm
    /// </summary>
    public class BatchConfirmTradeRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.trade.batch.confirm";
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
