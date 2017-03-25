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

        [XmlElement("start_time")]
        public string StartTime { get; set; }

        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
        
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
        /// 当前促销活动的关联的店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }


        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("item_description")]
        public string ItemDescription { get; set; }


        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("item_detail")]
        public string ItemDetail { get; set; }


        /// <summary>
        /// 商品预览图
        /// </summary>
        [XmlElement("item_images")]
        public string ItemImages { get; set; }


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
