using System.Xml.Serialization;

namespace Yun.Trade
{
    public class TradeCount
    {
        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("trade_count")]
        public int Count { get; set; }
    }
}
