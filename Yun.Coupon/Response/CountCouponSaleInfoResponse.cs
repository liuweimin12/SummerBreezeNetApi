using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    [XmlRoot("count_coupon_saleinfo_response")]
    public class CountCouponSaleInfoResponse : YunResponse
    {
        /// <summary>
        /// 销售情况
        /// </summary>
        [XmlElement("sale_info")]
        public ItemCouponSaleInfo SaleInfo { get; set; }
    }
}
