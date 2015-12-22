using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class AddSiteElementMultipeinfoRequest : ITopUploadRequest<IntResultResponse>
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
        /// 图片URL
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 超链接
        /// </summary>
        public string HyperLink { get; set; }

        /// <summary>
        /// 附加文本
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// 附加文本
        /// </summary>
        public string SecondAdditionalInfo { get; set; }

        /// <summary>
        /// 附加文本
        /// </summary>
        public string ThirdAdditionalInfo { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        public string Thumb { get; set; }


        public string GetApiName()
        {
            return "chenggou.site.element.multipeinfo.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title", Title},
                {"display",Display},
                {"sortorder",SortOrder},
                {"moduleid",ModuleId},
                {"hyperlink",HyperLink},
                {"additionalinfo",AdditionalInfo},
                {"secondadditionalinfo",SecondAdditionalInfo},
                {"thirdadditionalinfo",ThirdAdditionalInfo},
                {"parentid",ParentId},
                {"thumb", Thumb}
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

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "Image", Image } };
        }
    }
}
