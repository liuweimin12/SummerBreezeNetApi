using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Marketing
{
    public class PromotionInItem
    {
        /// <summary>
        /// 积分数量
        /// </summary>
        [XmlElement("item_integral_quantity")]
        public int ItemIntegralQuantity { get; set; }

        /// <summary>
        /// 积分限制
        /// </summary>
        [XmlElement("item_integral_limit")]
        public double ItemIntegrallimit { get; set; }


        [XmlElement("activity_id")]
        public int ActivityId { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("start_time")]
        public string StartTime { get; set; }

        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }


        [XmlElement("item_promo_price")]
        public double ItemPromoPrice { get; set; }


        [XmlArray("sku_prices")]
        [XmlArrayItem("sku_price")]
        public List<YunKeyValuePair<int, double>> SkuPrice { get; set; }

        /// <summary>
        /// 当前促销活动的关联的店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 限量
        /// </summary>
        [XmlElement("max_stock")]
        public int MaxStock { get; set; }



        /// <summary>
        /// 商品的扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }
    }
}
