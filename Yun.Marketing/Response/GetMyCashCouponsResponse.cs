using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_my_cash_coupons_response")]
    public class GetMyCashCouponsResponse : YunResponse
    {
        [XmlArray("cash_coupons")]
        [XmlArrayItem("cash_coupon")]
        public List<CashCoupon> CashCoupons { get; set; }
    }
}
