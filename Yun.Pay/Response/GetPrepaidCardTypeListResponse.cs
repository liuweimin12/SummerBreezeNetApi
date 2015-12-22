using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_prepaid_card_type_list_response")]
    public class GetPrepaidCardTypeListResponse : YunResponse
    {
        [XmlArray("prepaid_card_types")]
        [XmlArrayItem("prepaid_card_type")]
        public List<PrepaidCardTypeDomain> PrepaidCardTypes { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
