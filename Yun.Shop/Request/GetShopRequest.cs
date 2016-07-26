using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 获取商户信息
    /// </summary>
    public class GetShopRequest : ITopRequest<ShopResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        public string Fields { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
               {"fields",Fields}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
