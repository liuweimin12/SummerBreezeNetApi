using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;

namespace Yun.Logistics.Request
{
    public class GetExpressTemplatesRequest : ITopRequest<ExpressTemplateResponse>
    {
        public string GetApiName()
        {
            return "chenggou.freight.templates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new Dictionary<string, string>();
        }

        public void Validate()
        {
        }
    }
}
