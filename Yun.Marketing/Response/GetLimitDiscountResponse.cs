using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_limit_discount_response")]
    public class GetLimitDiscountResponse:YunResponse
    {
        [XmlElement("limit_discount_promotion")]
        public LimitDiscount LimitDiscountPromotion { get; set; }
    }
}
