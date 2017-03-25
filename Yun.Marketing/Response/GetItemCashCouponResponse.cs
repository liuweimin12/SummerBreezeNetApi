using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    /// <summary>
    /// 获取商品对应的优惠券列表
    /// </summary>
    [XmlRoot("get_item_cash_coupon_response")]
    public class GetItemCashCouponResponse : YunResponse
    {
        [XmlArray("cash_coupon_cateogries_with_receive_status")]
        [XmlArrayItem("cash_coupon_cateogry_with_receive_status")]
        public List<CashCouponCateogryWithReceiveStatus> CashCouponCateogryWithReceiveStatus { get; set; }
    }
}
