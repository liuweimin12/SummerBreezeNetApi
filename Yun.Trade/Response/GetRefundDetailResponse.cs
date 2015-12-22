using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    [XmlRoot("get_refund_detail_response")]
    public class GetRefundDetailResponse:YunResponse
    {
        [XmlElement("refund")]
        public RefundDetail Refund { get; set; }
    }
}
