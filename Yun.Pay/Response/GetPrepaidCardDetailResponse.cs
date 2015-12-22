using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_prepaid_card_detail_response")]
    public class GetPrepaidCardDetailResponse:YunResponse
    {
        [XmlElement("prepaid_card")]
        public PrepaidCardDomain PrepaidCard { get; set; }
    }
}
