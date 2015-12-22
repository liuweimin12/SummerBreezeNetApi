using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_combination_buy_detail_response")]
    public class GetCombinationBuyDetailResponse:YunResponse
    {
        [XmlElement("combination_buy_detail")]
        public CombinationBuyDetail CombinationBuyDetail { get; set; }
    }
}
