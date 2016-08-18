﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class AddSiteElementTextRequest : ITopRequest<IntResultResponse>
    {
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
        /// 超链接
        /// </summary>
        public string HyperLink { get; set; }

        /// <summary>
        /// 文本类型
        /// </summary>
        public int TextType { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.text.add";
        }

        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                 {"title", Title},
                {"display",Display},
                {"sortorder",SortOrder},
                {"moduleid",ModuleId},
                {"hyperlink",HyperLink},
                {"parentid",ParentId},
                {"texttype",TextType }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 2000);
            RequestValidator.ValidateRequired("display", Display);
            RequestValidator.ValidateRequired("sortorder", SortOrder);
            RequestValidator.ValidateRequired("moduleid", ModuleId);
            RequestValidator.ValidateRequired("hyperlink", HyperLink);
            RequestValidator.ValidateMaxLength("hyperlink", this.HyperLink, 2000);
        }
    }
}
