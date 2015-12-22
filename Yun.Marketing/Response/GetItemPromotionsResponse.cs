using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_item_promotions_response")]
    public class GetItemPromotionsResponse:YunResponse
    {
        [XmlArray("promotions_in_shop")]
        [XmlArrayItem("promotion_in_shop")]
        public List<PromotionInShop> PromotionInShop { get; set; }

        [XmlArray("promotions_in_item")]
        [XmlArrayItem("promotion_in_item")]
        public List<PromotionInItem> PromotionInItem { get; set; }

        [XmlArray("combination_promotions")]
        [XmlArrayItem("combination_promotion")]
        public List<CombinationPromotion> CombinationPromotion { get; set; }
    }
}
