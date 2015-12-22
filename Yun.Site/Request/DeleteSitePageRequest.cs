using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class DeleteSitePageRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 页面ID
        /// </summary>
        public int Id { get; set; }
        public string GetApiName()
        {
            return "chenggou.site.page.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
