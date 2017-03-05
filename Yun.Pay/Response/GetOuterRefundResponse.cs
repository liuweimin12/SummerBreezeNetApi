using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_outer_refund_response")]
    public class GetOuterRefundResponse : YunResponse, IPageResponse
    {
        [XmlArray("outer_refunds")]
        [XmlArrayItem("outer_refund")]
        public List<OuterRefund> OuterRefunds { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
