using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class UpdateDisplaySiteElementRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// 页面ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.updatedisplay";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"display",Display},
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("display", Display);
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
