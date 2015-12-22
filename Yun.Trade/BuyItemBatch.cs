using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class BuyItemBatch
    {
        /// <summary>
        /// 所选择的商品信息
        /// </summary>
        public List<BuyItem> Items { get; set; }

        /// <summary>
        /// 留言
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 选择的快递类型（快递，商家配送，自提）
        /// </summary>
        public string DeliveryType { get; set; }


        /// <summary>
        /// 店铺级别的优惠信息
        /// </summary>
        public int PromotionsActivityIdInShop { get; set; }
    }
}
