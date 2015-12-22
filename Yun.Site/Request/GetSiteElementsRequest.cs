using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class GetSiteElementsRequest : ITopRequest<ElementsResponse>
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public int ModuleId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.elements.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"moduleid", ModuleId },
                {"pagenum",PageNum},
                {"pagesize",PageSize}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("moduleid", ModuleId);
            RequestValidator.ValidateRequired("pagenum",PageNum);
            RequestValidator.ValidateRequired("pagesize",PageSize);
        }
    }
}
