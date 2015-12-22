using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    [XmlRoot("get_coupons_response")]
    public class GetCouponsResponse:YunResponse
    {
        [XmlArray("coupons")]
        [XmlArrayItem("coupon")]
        public List<CouponDetail> Coupons { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
