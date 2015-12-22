using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    public class FindCouponSaleInfoResponse : YunResponse
    {
        [XmlArray("item_coupon_saleinfoes")]
        [XmlArrayItem("item_coupon_saleinfo")]
        public List<ItemCouponSaleInfo> ItemCouponSaleInfoes { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
