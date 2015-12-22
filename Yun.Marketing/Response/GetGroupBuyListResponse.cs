using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    public class GetGroupBuyListResponse : YunResponse
    {
        [XmlArray("group_buy_promotions")]
        [XmlArrayItem("group_buy_promotion")]
        public List<LimitDiscountList> GroupBuyPromotions { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
