using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class UpdateSortSiteElementRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 排序
        /// </summary>
        public double Sort { get; set; }

        /// <summary>
        /// 页面ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.updatesort";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sort",Sort},
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sort",Sort);
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
