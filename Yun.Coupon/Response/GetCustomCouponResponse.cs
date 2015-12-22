using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    [XmlRoot("get_custom_coupon_response")]
    public class GetCustomCouponResponse: YunResponse
    {
        [XmlElement("custom_coupon")]
        public CustomCoupon CustomCoupon { get; set; }
    }
}
