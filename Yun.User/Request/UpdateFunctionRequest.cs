using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class UpdateFunctionRequest : ITopUploadRequest<BoolResultResponse>, IUploadInEditState
    {
        /// <summary>
        /// 页面名字，不能重复
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// 允许的权限（URL）集合
        /// </summary>
        public string AllowBlock { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.function.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"name", Name},
                {"sort",Sort},
                {"description",Description},
                {"parentid",ParentId},
                {"url",Url},
                {"display",Display},
                {"allowblock",AllowBlock},
                {"type",Type},
                {"image",Image}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 2000);
            RequestValidator.ValidateRequired("sort", Sort);
            RequestValidator.ValidateRequired("parentid", ParentId);
            RequestValidator.ValidateRequired("url", Url);
            RequestValidator.ValidateMaxLength("url", this.Url, 2000);
            RequestValidator.ValidateRequired("type", Type);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "Image", NewImage } };
        }

        public string Image { get; set; }
        public FileItem NewImage { get; set; }
    }
}
