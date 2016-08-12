using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 删除店铺收藏
    /// yun.shop.favorites.delete
    /// </summary>
    public class DeleteShopFavoriteRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店铺收藏的ID，多个用英文逗号分隔
        /// </summary>
        public string FavouriteIds { get; set; }


        public string GetApiName()
        {
            return "yun.shop.favorites.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"favouriteids", FavouriteIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("favouriteids", FavouriteIds);
        }
    }
}
