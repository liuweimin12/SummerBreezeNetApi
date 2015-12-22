using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_shop_prepaid_card_statistics_response")]
    public class GetShopPrepaidCardStatisticsResponse : YunResponse, IPageResponse
    {
        [XmlArray("shop_prepaid_card_statisticses")]
        [XmlArrayItem("shop_prepaid_card_statistics")]
        public List<ShopPrepaidCardStatisticsDomain> ShopPrepaidCardStatisticses { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
