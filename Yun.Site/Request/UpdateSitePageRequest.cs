using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class UpdateSitePageRequest : ITopUploadRequest<BoolResultResponse>
    {
        /// <summary>
        /// 页面名字，不能重复
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 页面ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 模块缩略图URL
        /// </summary>
        public string Thumb { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.page.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"id", Id},
                {"thumb", Thumb},
                {"remark", Remark}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 2000);
            RequestValidator.ValidateRequired("id", Id);
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
