using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 更新商品价格
    /// yun.item.price.update
    /// </summary>
    public class UpdateItemPriceRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// SKUiD
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public double Price { get; set; }

        public string GetApiName()
        {
            return "yun.item.price.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"skuid", SkuId},
                {"price",Price}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
            RequestValidator.ValidateMinValue("itemid", ItemId, 1);
            RequestValidator.ValidateRequired("price", Price);
            RequestValidator.ValidateMinValue("price", Price, 0);
        }
    }
}
