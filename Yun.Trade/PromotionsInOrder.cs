using System.Xml.Serialization;

namespace Yun.Trade
{
    public class PromotionsInOrder
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public int ActivityId { get; set; }


        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 便宜了多少钱
        /// </summary>
        [XmlElement("price")]
        public double Price { get; set; }


        /// <summary>
        /// 促销活动类型
        /// </summary>
        [XmlElement("promotions_type")]
        public int PromotionsType { get; set; }


        /// <summary>
        /// 送礼品的商品ID
        /// </summary>
        [XmlElement("gift_id")]
        public int GiftId { get; set; }

        /// <summary>
        /// 礼品名字
        /// </summary>
        [XmlElement("gift_name")]
        public string GiftName { get; set; }


        /// <summary>
        /// 是否包邮
        /// </summary>
        [XmlElement("is_free_post")]
        public bool IsFreePost { get; set; }


        /// <summary>
        /// 促销的扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}