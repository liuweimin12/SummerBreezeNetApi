using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class TradesResponse : YunResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlArray("trades")]
        [XmlArrayItem("trade")]
        public List<SnapshotTrade> Trades { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }

    }
}
