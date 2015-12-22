using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class UpdateSitePageModuleRequest : ITopUploadRequest<BoolResultResponse>
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 模块名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 模块缩略图URL
        /// </summary>
        public string ModuleThumb { get; set; }


        /// <summary>
        /// 模块标识，必须保证唯一性
        /// </summary>
        public string ModuleFlag { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.page.module.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"name",Name},
                {"modulethumb", ModuleThumb},
                {"remark", Remark},
                {"moduleflag", ModuleFlag},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", Name, 2000);
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
