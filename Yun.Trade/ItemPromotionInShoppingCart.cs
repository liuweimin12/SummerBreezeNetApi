using System.Xml.Serialization;

namespace Yun.Trade
{
    public class ItemPromotionInShoppingCart
    {
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
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 优惠的价格
        /// </summary>
        [XmlElement("item_promo_price")]
        public double ItemPromoPrice { get; set; }


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
        /// 用户类型
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 店铺ID
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
