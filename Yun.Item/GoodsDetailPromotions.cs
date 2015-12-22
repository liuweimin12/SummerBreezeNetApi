using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Item
{
    public class GoodsDetailPromotions
    {
        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public int ActivityId { get; set; }

        /// <summary>
        /// 活动名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动的优惠价格
        /// </summary>
        [XmlElement("item_promo_price")]
        public double ItemPromoPrice { get; set; }

        /// <summary>
        /// 商品SKU中优惠的价格
        /// </summary>
        [XmlArray("sku_prices")]
        [XmlArrayItem("sku_price")]
        public List<YunKeyValuePair<int, double>> SkuPrice { get; set; }

        /// <summary>
        /// 限量
        /// </summary>
        [XmlElement("max_stock")]
        public int MaxStock { get; set; }


        /// <summary>
        /// 当前促销活动的关联的店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 商品的扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}
