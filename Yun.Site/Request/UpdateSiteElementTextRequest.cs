using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class UpdateSiteElementTextRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public double SortOrder { get; set; }

        /// <summary>
        /// 超链接
        /// </summary>
        public string HyperLink { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.text.update";
        }

        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"title",Title},
                {"display",Display},
                {"sortorder",SortOrder},
                {"hyperlink",HyperLink},
                {"parentid",ParentId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 200);
            RequestValidator.ValidateRequired("display", Display);
            RequestValidator.ValidateRequired("sortorder", SortOrder);
            RequestValidator.ValidateRequired("hyperlink", HyperLink);
            RequestValidator.ValidateMaxLength("hyperlink", this.HyperLink, 2000);
        }
    }
}
