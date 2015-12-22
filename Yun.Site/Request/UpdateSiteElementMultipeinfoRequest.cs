using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class UpdateSiteElementMultipeinfoRequest : ITopUploadRequest<BoolResultResponse>, IUploadInEditState
    {
        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

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
        /// 图片URL
        /// </summary>
        public string Image { get; set; }

        public FileItem NewImage { get; set; }

        /// <summary>
        /// 超链接
        /// </summary>
        public string HyperLink { get; set; }

        /// <summary>
        /// 附加文本1
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// 附加文本2
        /// </summary>
        public string SecondAdditionalInfo { get; set; }

        /// <summary>
        /// 附加文本3
        /// </summary>
        public string ThirdAdditionalInfo { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.multipeinfo.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"title",Title},
                {"display",Display},
                {"sortorder",SortOrder},
                {"image",Image},
                {"hyperlink",HyperLink},
                {"additionalinfo",AdditionalInfo},
                {"secondadditionalinfo",SecondAdditionalInfo},
                {"thirdadditionalinfo",ThirdAdditionalInfo},
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
            RequestValidator.ValidateMaxLength("image", this.Image, 2000);
            RequestValidator.ValidateRequired("hyperlink", HyperLink);
            RequestValidator.ValidateMaxLength("hyperlink", this.HyperLink, 2000);
            RequestValidator.ValidateMaxLength("additionalinfo", this.AdditionalInfo,2000);
            RequestValidator.ValidateMaxLength("secondadditionalinfo", this.SecondAdditionalInfo, 2000);
            RequestValidator.ValidateMaxLength("thirdadditionalinfo", this.ThirdAdditionalInfo, 2000);

        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "newimage", NewImage } };
        }
    }
}
