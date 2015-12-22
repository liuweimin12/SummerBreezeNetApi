using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    [XmlRoot("get_month_trade_statistics_response")]
    public class GetMonthTradeStatisticsResponse: YunResponse
    {
        [XmlArray("trading_statisticss")]
        [XmlArrayItem("trading_statistics")]
        public List<MonthTradeStatistics> TradingStatistics { get; set; }
    }
}
