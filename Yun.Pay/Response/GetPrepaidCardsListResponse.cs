using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_prepaid_cards_list_response")]
    public class GetPrepaidCardsListResponse:YunResponse
    {
        [XmlArray("prepaid_cards")]
        [XmlArrayItem("prepaid_card")]
        public List<PrepaidCardDomain> PrepaidCards { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
