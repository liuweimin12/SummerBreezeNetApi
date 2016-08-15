using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class UpdateCartRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 购物车ID
        /// </summary>
        public int CartId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string UserFlag { get; set; }

        /// <summary>
        /// 所选择的SKUID，如果为空，则不变更
        /// </summary>
        public int? SkuId { get; set; }

        public string GetApiName()
        {
            return "chenggou.shoppingcart.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cartid", CartId},
                {"quantity", Quantity},
                {"userflag",UserFlag},
                {"skuid",SkuId }
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cartid", CartId);
            RequestValidator.ValidateMinValue("quantity", Quantity, 0);
        }
    }
}