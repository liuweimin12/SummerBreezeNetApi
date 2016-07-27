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
    /// 收藏商品
    /// yun.item.favorites.add
    /// </summary>
    public class AddFavoritesItemRequest : ITopRequest<AddFavoritesItemResponse>
    {
        /// <summary>
        /// 商品ID，多个用英文逗号分隔
        /// </summary>
        public string ItemIds { get; set; }

        public string GetApiName()
        {
            return "yun.item.favorites.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemids", ItemIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemids", ItemIds);
        }
    }
}
