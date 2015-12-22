using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
     [XmlRoot("get_coupons_response")]
    public class GetCouponResponse:YunResponse
    {
         [XmlElement("coupon")]
        public CouponDetail Coupon { get; set; }

    }
}
