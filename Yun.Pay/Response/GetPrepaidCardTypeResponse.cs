using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_prepaid_card_type_response")]
    public class GetPrepaidCardTypeResponse:YunResponse
    {
        [XmlElement("prepaid_card_type")]
        public PrepaidCardTypeDomain PrepaidCardType { get; set; }
    }
}
