
namespace Yun.Domain
{
    public class TradeGiftJson
    {
        /// <summary>
        /// 礼物ID
        /// </summary>
        public int gift_id { get; set; }

        /// <summary>
        /// 所选择的SKUID
        /// </summary>
        public int sku_id { get; set; }

        /// <summary>
        /// 是否是电子券
        /// </summary>
        public bool is_coupon { get; set; }
    }
}
