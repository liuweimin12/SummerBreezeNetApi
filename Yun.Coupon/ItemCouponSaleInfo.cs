using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Coupon
{
    public class ItemCouponSaleInfo
    {
        [XmlElement("item_id")]
        public int ItemId { get; set; }


        /// <summary>
        /// 销量，笔数
        /// </summary>
        [XmlElement("number_of_sales")]
        public int NumberOfSales { get; set; }

        /// <summary>
        /// 销量，件
        /// </summary>
        [XmlElement("sum_number_of_sales")]
        public int SumNumberOfSales { get; set; }

        /// <summary>
        /// 已核销数
        /// </summary>
        [XmlElement("used_number")]
        public int UsedNumber { get; set; }

        /// <summary>
        /// 未核销数
        /// </summary>
        [XmlElement("not_used")]
        public int NotUsed { get; set; }
    }
}
