using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class GetItemEvaluateResponse: YunResponse
    {
        [XmlArray("trade_evaluates")]
        [XmlArrayItem("trade_evaluate")]
        public List<TradeEvaluate> TradeEvaluates { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
