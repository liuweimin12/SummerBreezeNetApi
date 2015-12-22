using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{

    public class GetTradeCountResponse : YunResponse
    {
        [XmlArray("trade_counts")]
        [XmlArrayItem("trade_count")]
        public List<TradeCount> Result { get; set; }
    }
}
