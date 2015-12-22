using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;

namespace Yun.Shop.Request
{
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
