using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class AddSitePageModuleRequest : ITopUploadRequest<IntResultResponse>
    {
        /// <summary>
        /// 页面ID
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// 模块名
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 模块类型
        /// </summary>
        public string ModuleType { get; set; }

        /// <summary>
        /// 模块标识，必须保证唯一性
        /// </summary>
        public string ModuleFlag { get; set; }

        /// <summary>
        /// 模块缩略图URL
        /// </summary>
        public string ModuleThumb { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.page.module.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pageid", PageId},
                {"name", Name},
                {"moduletype", ModuleType},
                {"moduleflag", ModuleFlag},
                {"modulethumb", ModuleThumb},
                {"remark", Remark}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pageid", PageId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("moduletype", ModuleType);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem>
            {
                {"Image", Image}
            };
        }

        /// <summary>
        /// 缩略图
        /// </summary>
        public FileItem Image { get; set; }
    }
}