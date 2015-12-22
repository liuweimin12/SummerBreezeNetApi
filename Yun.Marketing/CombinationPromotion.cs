using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class CombinationPromotion
    {
        /// <summary>
        /// 促销活动ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 促销活动名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }


        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }


        [XmlArray("combination_items")]
        [XmlArrayItem("combination_item")]
        public List<CombinationItem> CombinationItems { get; set; }

        [XmlElement("price")]
        public double Price { get; set; }

        [XmlElement("market_price")]
        public string MarketPrice { get; set; }

        [XmlElement("images")]
        public string Images { get; set; }

        [XmlElement("fare_template_id")]
        public int FareTemplateId { get; set; }

        [XmlElement("coupon_template_id")]
        public int CouponTemplateId { get; set; }
    }
}
