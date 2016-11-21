

namespace Yun.Trade
{
    public class CreateOrderVerificationJson
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int item_id { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// 选择属性
        /// </summary>
        public int sku_id { get; set; }

        /// <summary>
        /// 商品级别促销信息
        /// </summary>
        public int item_promotions_activity_id { get; set; }
    }
}
