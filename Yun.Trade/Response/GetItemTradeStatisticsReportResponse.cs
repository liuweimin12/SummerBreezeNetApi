using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class GetItemTradeStatisticsReportResponse : YunResponse
    {
        [XmlArray("item_trading_statisticss")]
        [XmlArrayItem("item_trading_statistics")]
        public List<ItemTradeStatistics> ItemTradingStatistics { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
