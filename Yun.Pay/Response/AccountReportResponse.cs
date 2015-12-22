using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class AccountReportResponse : YunResponse, IPageResponse
    {
        [XmlArray("records")]
        [XmlArrayItem("record")]
        public List<FlowRecord> Records { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }

    }
}
