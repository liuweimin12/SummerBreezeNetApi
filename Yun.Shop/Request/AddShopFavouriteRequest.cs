using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 新增店铺收藏
    /// yun.shop.favorites.add
    /// </summary>
    public class AddShopFavouriteRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }


        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        public string GetApiName()
        {
            return "yun.shop.favorites.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"note", Note},
                {"sort", Sort}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("shopid", ShopId, 1);
        }
    }
}
