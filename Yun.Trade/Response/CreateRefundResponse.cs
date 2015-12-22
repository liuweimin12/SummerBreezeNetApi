using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Trade.Response
{
    [XmlRoot("create_refund_response")]
    public class  CreateRefundResponse:YunResponse
    {
        [XmlElement("refund_data")]
        public YunKeyValuePair<long, string> RefundData { get; set; }
    }
}
