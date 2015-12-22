using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    public class GetSitePagesRequest : ITopRequest<PagesResponse>    
    {
        public string GetApiName()
        {
            return "chenggou.site.pages.get";
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
