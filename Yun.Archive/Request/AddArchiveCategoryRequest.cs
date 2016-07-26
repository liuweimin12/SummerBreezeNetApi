using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 新增文章分类
    /// 需要授权
    /// </summary>
    public class AddArchiveCategoryRequest : ITopUploadRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.category.add";
        }

        /// <summary>
        /// 分类名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 文章的缩略图
        /// </summary>
        public FileItem Image { get; set; }


        /// <summary>
        /// 缩略图
        /// </summary>
        public string Thumb { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Extension { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 分类缩写，需要唯一
        /// </summary>
        public string Slug { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"parentid", ParentId},
                {"sort", Sort},
                {"display", Display},
                {"description", Description},
                {"thumb", Thumb},
                {"extension", Extension},
                {"shopid", ShopId},
                {"companyid", CompanyId},
                { "slug",Slug }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", Name, 200);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "Image", Image } };
        }
    }
}
