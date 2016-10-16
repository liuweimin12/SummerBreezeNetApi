using System.Collections.Generic;
using Yun.Domain;

namespace Yun.Trade
{
    public class ExpressFeePriceArgs
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        public List<BuyGoods> goods_info { get; set; }

        /// <summary>
        /// 选择的快递类型（快递，商家配送，自提）
        /// </summary>
        public string delivery { get; set; }

        /// <summary>
        /// 店铺级别的优惠信息
        /// </summary>
        public int promotions_activity_id_in_shop { get; set; }

        /// <summary>
        /// 赠送的礼品
        /// </summary>
        public List<TradeGiftJson> gifts { get; set; }
    }
}
