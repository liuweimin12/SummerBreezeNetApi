using System.Collections.Generic;
using Yun.Domain;
using Yun.Interface;
using Yun.Response;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    public class GetSiteModulesTypeRequest : ITopRequest<ModuleTypesResponse>
    {
        public string GetApiName()
        {
            return "chenggou.site.modulestype.get";
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
