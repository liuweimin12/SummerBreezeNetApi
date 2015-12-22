using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    
    public class GetMyTradeCountRequest: ITopRequest<GetTradeCountResponse>
    {

        public string GetApiName()
        {
            return "chenggou.buyer.trade.count";
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
