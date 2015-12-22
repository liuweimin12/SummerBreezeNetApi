using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class GetShoppingCartsRequest : ITopRequest<CartsResponse>
    {
        public string GetApiName()
        {
            return "chenggou.shoppingcart.items.get";
        }

        /// <summary>
        /// 购物车IDS
        /// </summary>
        public string CartIds { get; set; }

        /// <summary>
        /// 类型，数字表示，默认为0
        /// </summary>
        public int CartType { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        public string UserFlag { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cartids", CartIds},
                {"carttype", CartType},
                {"shopid", ShopId},
                {"userflag",UserFlag},
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("shopid", ShopId, 0);
        }
    }
}
