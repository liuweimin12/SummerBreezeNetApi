using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    [XmlRoot("get_trade_statistics_response")]
     public class GetDailyTradeStatisticsResponse:YunResponse
    {
        [XmlArray("trading_statisticss")]
        [XmlArrayItem("trading_statistics")]
        public List<TradeStatistics> TradingStatistics { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }


        /// <summary>
        /// 交易数据的累加
        /// </summary>
        [XmlElement("sum_trade_statistics")]
        public TradeStatisticsSummary SumTradeStatistics { get; set; }
    }
}
