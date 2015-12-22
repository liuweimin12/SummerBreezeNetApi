using System.Collections.Generic;
using System.Web;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class AddSiteElementCustomBoxRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

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
        /// 模块ID或模块标识
        /// </summary>
        public int ModuleId { get; set; }

        /// <summary>
        /// 自定义内容
        /// </summary>
        public string CustomText { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.custombox.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title", Title},
                {"display",Display},
                {"sortorder",SortOrder},
                {"moduleid",ModuleId},
                {"customtext",HttpUtility.HtmlEncode(CustomText)},
                {"parentid",ParentId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateMaxLength("title", Title, 200);
            RequestValidator.ValidateRequired("display",Display);
            RequestValidator.ValidateRequired("sortorder", SortOrder);
            RequestValidator.ValidateRequired("moduleid", ModuleId);
            RequestValidator.ValidateRequired("customtext", CustomText);
        }

    }
}
