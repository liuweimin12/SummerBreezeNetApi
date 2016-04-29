using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class UpdateCategoryRequest : ITopUploadRequest<BoolResultResponse>, IUploadInEditState
    {
        public string GetApiName()
        {
            return "chenggou.archive.category.update";
        }

        /// <summary>
        /// 文章Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序规则，越大约前面
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }


        /// <summary>
        /// 文章的缩略图
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 上传的图片
        /// </summary>
        public FileItem NewImage { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Extension { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"name", Name},
                {"sort", Sort},
                {"display", Display},
                {"image",Image},
                {"description",Description},
                {"parentid",ParentId},
                {"extension",Extension }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", Name, 200);
            RequestValidator.ValidateRequired("sort", Sort);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "NewImage", NewImage } };
        }
    }
}
