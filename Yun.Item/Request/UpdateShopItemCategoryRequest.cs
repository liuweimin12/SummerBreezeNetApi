using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class UpdateShopItemCategoryRequest : ITopUploadRequest<BoolResultResponse>
    {
        /// <summary>
        /// 文章Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Title { get; set; }

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
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "newimage", NewImage } };
        }

        public string GetApiName()
        {
            return "chenggou.shop.item.category.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"title", Title},
                {"sort", Sort},
                {"display", Display},
                {"image", Image},
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("title",Title);
            RequestValidator.ValidateMaxLength("title",this.Title,200);
            RequestValidator.ValidateRequired("sort",Sort);
            RequestValidator.ValidateRequired("display",Display);
        }
    }
}
