using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Response;

namespace Yun.Pay.Request
{
    public class GetDefaultPaymentRateRequest : ITopRequest<GetDefaultPayMentRateResponse>
    {
        public string GetApiName()
        {
            return "chenggou.pay.defaultpaymentrate.get";
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
