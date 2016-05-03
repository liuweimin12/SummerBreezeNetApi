using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取店铺内商品分类
    /// </summary>
    public class GetShopItemCategorysRequest : ITopRequest<CategorysResponse>
    {
        /// <summary>
        /// -1全部,0不显示, 1显示
        /// </summary>
        public int? Display { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.item.categorys.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"display",Display},
                {"parentid",ParentId},
                {"shopid",ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopid",ShopId);
        }
    }
}
