using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("promotionmisc_activity_rangelist_getresponse")]
    public class PromotionmiscActivityRangeListGetResponse:YunResponse
    {
        [XmlArray("promotion_range")]
        [XmlArrayItem("promotion_range")]
        public List<PromotionRange> PromotionRangeList { get; set; }
    }
}
