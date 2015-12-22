using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class AddSitePageRequest : ITopUploadRequest<IntResultResponse>
    {
        /// <summary>
        /// 模块缩略图URL
        /// </summary>
        public string Thumb { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 页面名字，不能重复
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.page.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"thumb", Thumb},
                {"remark", Remark},
                {"companyid", CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
        }

        /// <summary>
        /// 缩略图
        /// </summary>
        public FileItem Image { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem>
            {
                {"Image", Image}
            };
        }
    }
}
