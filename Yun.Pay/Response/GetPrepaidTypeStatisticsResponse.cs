using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GetPrepaidTypeStatisticsResponse : YunResponse
    {
        [XmlElement("prepaid_card_statistics")]
        public PrepaidCardStatistics PrepaidCardStatistics { get; set; }
    }
}
