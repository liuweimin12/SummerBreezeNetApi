using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    public class GetTemplateResponse: YunResponse
    {
        [XmlElement("coupon_template")]
        public CouponTemplate Result { get; set; }
    }
}
