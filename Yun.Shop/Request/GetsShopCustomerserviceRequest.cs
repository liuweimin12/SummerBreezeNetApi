using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class GetsShopCustomerServiceRequest : ITopRequest<CustomerServicesResponse>    
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        public string GetApiName()
        {
            return "chenggou.shop.customerservices.get";
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
            RequestValidator.ValidateRequired("shopid", ShopId);
        }
    }
}
