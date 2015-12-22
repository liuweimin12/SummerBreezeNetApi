using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("find_cash_coupon_response")]
    public class FindCashCouponResponse : YunResponse
    {
        [XmlArray("cash_coupons")]
        [XmlArrayItem("cash_coupon")]
        public List<CashCouponDomain> CashCoupons { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
