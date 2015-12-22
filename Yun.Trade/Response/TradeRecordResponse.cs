using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class TradeRecordResponse: YunResponse
    {
        [XmlArray("trade_records")]
        [XmlArrayItem("trade_record")]
        public List<TradeRecord> Trades { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
