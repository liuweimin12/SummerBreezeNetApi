using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
     [XmlRoot("get_refunds_response")]
    public class GetRefundsResponse:YunResponse
    {
        [XmlArray("refunds")]
        [XmlArrayItem("refund")]
        public List<RefundDetail> Refunds { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
