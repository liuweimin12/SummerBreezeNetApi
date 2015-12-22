using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class CloseTradeRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public string CloseReason { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.close";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"closereason", CloseReason}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("closereason", CloseReason);
        }
    }
}
