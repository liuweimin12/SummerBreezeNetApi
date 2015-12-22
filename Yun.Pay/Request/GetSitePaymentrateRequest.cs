using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class GetSitePaymentrateRequest : ITopRequest<GetSitePaymentrateResponse>
    {
        public int DeveloperId { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.paymentrate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"developerid", DeveloperId},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("developerid", DeveloperId);
        }
    }
}
