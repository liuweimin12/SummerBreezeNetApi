using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 更新店铺收藏的备注
    /// yun.shop.favorites.updateremark
    /// </summary>
    public class UpdateShopFavoriteRemarkRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店铺收藏的ID
        /// </summary>
        public int FavouriteId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        public string GetApiName()
        {
            return "yun.shop.favorites.updateremark";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"favouriteid", FavouriteId},
                {"remarks", Remarks}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("favouriteid", FavouriteId);
            RequestValidator.ValidateRequired("remarks", Remarks);
        }
    }
}
