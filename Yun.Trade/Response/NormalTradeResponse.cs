using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
     public class NormalTradeResponse: YunResponse
    {
         /// <summary>
        /// 交易详情
         /// </summary>
         [XmlElement("trade")]
         public SnapshotTrade Trade { get; set; }
    }
}
