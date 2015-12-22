using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;
using Yun.Trade.Request;

namespace Yun.Trade.Response
{
    [XmlRoot("get_integral_response")]
    public class GetIntegralResponse:YunResponse
    {
        [XmlElement("integral_rule")]
        public IntegralDomain IntegralRule { get; set; }
    }
}
