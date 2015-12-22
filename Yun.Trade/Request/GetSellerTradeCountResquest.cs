using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    public class GetSellerTradeCountResquest : ITopRequest<GetTradeCountResponse>
    {
        public string GetApiName()
        {
            return "chenggou.seller.trade.count";
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
