using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_combination_buy_list_response")]
    public class GetCombinationBuyListResponse:YunResponse
    {
        [XmlArray("combination_buies")]
        [XmlArrayItem("combination_buy")]
        public List<CombinationBuyList> CombinationBuies { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
