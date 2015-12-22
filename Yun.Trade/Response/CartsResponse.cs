using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class CartsResponse : YunResponse
    {
        [XmlArray("items")]
        [XmlArrayItem("item")]
        public List<CartDetail> Items { get; set; }

        [XmlArray("shop_promotions")]
        [XmlArrayItem("shop_promotion")]
        public List<ShopPromotionInShoppingCart> ShopPromotion { get; set; }
    }
}
