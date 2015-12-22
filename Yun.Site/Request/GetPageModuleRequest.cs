using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class GetPageModuleRequest : ITopRequest<GetPageModuleResponse>
    {
        public int ModuleId { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.page.module.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"moduleid", ModuleId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("moduleid", ModuleId);
        }
    }
}
