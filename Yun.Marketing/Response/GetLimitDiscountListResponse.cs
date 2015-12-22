using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_limit_discount_list_response")]
    public class GetLimitDiscountListResponse:YunResponse
    {
        [XmlArray("limit_discount_promotions")]
        [XmlArrayItem("limit_discount_dromotion")]
        public List<LimitDiscountList> LimitDiscountPromotions { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
