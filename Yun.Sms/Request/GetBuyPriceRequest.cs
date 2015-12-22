using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Sms.Response;

namespace Yun.Sms.Request
{
    public class GetBuyPriceRequest : ITopRequest<GetBuyPriceResponse>
    {
        public string GetApiName()
        {
            return "chenggou.sms.price.get";
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
