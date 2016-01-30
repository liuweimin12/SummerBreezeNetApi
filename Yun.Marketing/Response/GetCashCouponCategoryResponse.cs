
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_cash_coupon_category_response")]
    public class GetCashCouponCategoryResponse : YunResponse
    {
        /// <summary>
        /// 代金券分类
        /// </summary>
        [XmlElement("cashcoupon_cateogry")]
        public CashCouponCateogry CashCouponCateogry { get; set; }
    }
}