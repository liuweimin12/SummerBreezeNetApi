using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;

namespace Yun.Shop.Request
{
    public class GetShopHomeSeoRequest : ITopRequest<SeoResponse>   
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.home.seo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
