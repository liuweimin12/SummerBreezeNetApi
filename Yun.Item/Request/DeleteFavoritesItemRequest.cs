using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 将商品移出收藏夹
    /// yun.item.favorites.delete
    /// </summary>
    public class DeleteFavoritesItemRequest : ITopRequest<DeleteFavoritesItemResponse>
    {
        /// <summary>
        /// 收藏夹内的收藏ID，多个用英文逗号分隔
        /// </summary>
        public string FavoriteIds { get; set; }


        public string GetApiName()
        {
            return "yun.item.favorites.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"favoriteids", FavoriteIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("favoriteids", FavoriteIds);
        }
    }
}
