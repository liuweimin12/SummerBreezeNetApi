using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class CartDetail
    {
        /// <summary>
        /// 选择的递送方式
        /// </summary>
        [XmlElement("delivery")]
        public string Delivery { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 购物车ID
        /// </summary>
        [XmlElement("card_id")]
        public long CardId { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item_info")]
        public CartItemDetail ItemInfo { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 关联店铺
        /// </summary>
        [XmlElement("associated_shop_info")]
        public AssociatedShopInfo AssociatedShopInfo { get; set; }

        /// <summary>
        /// 是否被删除
        /// </summary>
        [XmlElement("is_delete")]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 商品级别的促销信息
        /// </summary>
        [XmlArray("item_promotions")]
        [XmlArrayItem("item_promotion")]
        public List<ItemPromotionInShoppingCart> ItemPromotion { get; set; }

    }
}
