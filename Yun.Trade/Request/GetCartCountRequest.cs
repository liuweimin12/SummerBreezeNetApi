using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取购物车内商品数量
    /// </summary>
    public class GetCartCountRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 类型，数字表示，默认为0
        /// </summary>
        public int CartType { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 匿名用户标识
        /// </summary>
        public string UserFlag { get; set; }

        public string GetApiName()
        {
            return "chenggou.shoppingcart.items.count";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
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
