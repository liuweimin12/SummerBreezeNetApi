
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    [XmlRoot("get_custom_coupon_overview_response")]
    public class GetCustomCouponOverviewResponse : YunResponse
    {
        [XmlElement("custom_coupon_overview")]
        public CustomCouponOverview CustomCouponOverview { get; set; }
    }
}
