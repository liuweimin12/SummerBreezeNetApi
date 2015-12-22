using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    [XmlRoot("find_custom_coupon_response")]
    public class FindCustomCouponResponse : YunResponse, IPageResponse
    {
        [XmlArray("custom_coupons")]
        [XmlArrayItem("custom_coupon")]
        public List<CustomCoupon> CustomCoupons { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
