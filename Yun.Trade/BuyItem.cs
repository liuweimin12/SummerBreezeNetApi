
namespace Yun.Trade
{
    public class BuyItem
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public long ItemId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public long Quantity { get; set; }

        /// <summary>
        /// 选择属性
        /// </summary>
        public long SkuId { get; set; }

        /// <summary>
        /// 商品级别的促销ID
        /// </summary>
        public int PromotionsActivityIdInItem { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public int? OrderType { get; set; }
    }
}
