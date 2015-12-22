using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class AddShopItemCategoryRequest : ITopUploadRequest<IntResultResponse>
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

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
        public FileItem Image { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        public string Thumb { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "Image", Image } };
        }

        public string GetApiName()
        {
            return "chenggou.shop.item.category.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title", this.Title},
                {"parentid",ParentId},
                {"sort",Sort},
                {"display",Display},
                {"thumb",Thumb}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 200);
            RequestValidator.ValidateRequired("parentid",ParentId);
            RequestValidator.ValidateRequired("sort",Sort);
            RequestValidator.ValidateRequired("display",Display);
        }
    }
}
