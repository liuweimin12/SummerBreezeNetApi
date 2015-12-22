using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class GetSitePageModulesRequest : ITopRequest<GetPageModulesResponse>      
    {
        /// <summary>
        /// 页面ID
        /// </summary>
        public int PageId { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.page.modules.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pageid", PageId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pageid", PageId);
        }
    }
}
