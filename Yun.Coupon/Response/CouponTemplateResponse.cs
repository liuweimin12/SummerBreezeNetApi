using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    public class CouponTemplateResponse : YunResponse
    {
        [XmlArray("coupon_templates")]
        [XmlArrayItem("coupon_template")]
        public List<CouponTemplate> CouponTemplates { get; set; }
    }
}
