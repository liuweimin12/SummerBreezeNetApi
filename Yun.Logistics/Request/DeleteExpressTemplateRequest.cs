using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Logistics.Request
{
    public class DeleteExpressTemplateRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.freight.template.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
