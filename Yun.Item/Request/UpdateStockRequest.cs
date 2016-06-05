using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 修改库存接口
    /// yun.item.stock.update
    /// </summary>
    public class UpdateStockRequest : ITopRequest<IntResultResponse>
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
        public int Stock { get; set; }

        public string GetApiName()
        {
            return "yun.item.stock.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"skuid", SkuId},
                {"stock",Stock}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
            RequestValidator.ValidateMinValue("itemid", ItemId, 1);
            RequestValidator.ValidateRequired("stock", Stock);
            RequestValidator.ValidateMinValue("stock", Stock, 0);
        }
    }
}
