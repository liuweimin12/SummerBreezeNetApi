using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_cash_coupon_response")]
    public class GetCashCouponResponse: YunResponse
    {
        /// <summary>
        /// 代金券
        /// </summary>
        [XmlElement("cash_coupon")]
        public CashCouponDomain CashCoupon { get; set; }
    }
}
