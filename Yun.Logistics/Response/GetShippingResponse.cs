using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    [XmlRoot("get_shipping_response")]
    public class GetShippingResponse:YunResponse
    {
        [XmlElement("shipping_record")]
        public ShippingRecord Record { get; set; }
    }
}
