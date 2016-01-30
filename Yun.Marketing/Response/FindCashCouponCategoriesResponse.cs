using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("find_cashcoupon_categories_response")]
    public class FindCashCouponCategoriesResponse : YunResponse
    {
        /// <summary>
        /// 代金券分类
        /// </summary>
        [XmlArray("cashcoupon_cateogries")]
        [XmlArrayItem("cashcoupon_cateogry")]
        public List<CashCouponCateogry> CashCouponCateogries { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
