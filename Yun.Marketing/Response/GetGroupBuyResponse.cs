
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    public class GetGroupBuyResponse : YunResponse
    {
        [XmlElement("group_buy")]
        public GroupBuy GroupBuy { get; set; }
    }
}
