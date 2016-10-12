
namespace Yun.Trade
{
    public class BuyGoods
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
        public int promotions_activity_id_in_item { get; set; }

        /// <summary>
        /// 是否是礼品
        /// </summary>
        public bool is_gift { get; set; }


        /// <summary>
        /// 是否是电子券
        /// </summary>
        public bool is_coupon { get; set; }
    }
}
