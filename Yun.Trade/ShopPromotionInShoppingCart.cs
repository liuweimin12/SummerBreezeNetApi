using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class ShopPromotionInShoppingCart
    {

        [XmlElement("activity_id")]
        public int ActivityId { get; set; }


        [XmlElement("name")]
        public string Name { get; set; }


        [XmlElement("description")]
        public string Description { get; set; }


        /// <summary>
        /// 是否有减钱行为
        /// </summary>
        [XmlElement("is_decrease_money")]
        public bool IsDecreaseMoney { get; set; }

        /// <summary>
        /// 减钱金额
        /// </summary>
        [XmlElement("decrease_amount")]
        public double DecreaseAmount { get; set; }


        /// <summary>
        /// 是否有打折行为
        /// </summary>
        [XmlElement("discount_rate")]
        public double DiscountRate { get; set; }

        /// <summary>
        /// 是否有打折行为
        /// </summary>
        [XmlElement("is_discount")]
        public bool IsDiscount { get; set; }


        /// <summary>
        /// 是否有满元条件
        /// </summary>
        [XmlElement("is_amount_over")]
        public bool IsAmountOver { get; set; }

        /// <summary>
        /// 满多少元
        /// </summary>
        [XmlElement("total_price")]
        public double TotalPrice { get; set; }

        /// <summary>
        /// 满元是否上不封顶
        /// </summary>
        [XmlElement("is_amount_multiple")]
        public bool IsAmountMultiple { get; set; }


        /// <summary>
        /// 是否有满件条件
        /// </summary>
        [XmlElement("is_item_count_over")]
        public bool IsItemCountOver { get; set; }


        /// <summary>
        /// 满多少件
        /// </summary>
        [XmlElement("item_count")]
        public int ItemCount { get; set; }


        /// <summary>
        /// 满件是否上不封顶
        /// </summary>
        [XmlElement("is_item_multiple")]
        public bool IsItemMultiple { get; set; }


        /// <summary>
        /// 是否有送礼品行为
        /// </summary>
        [XmlElement("is_send_gift")]
        public bool IsSendGift { get; set; }


        /// <summary>
        /// 送的礼品
        /// </summary>
        [XmlArray("gifts")]
        [XmlArrayItem("gift")]
        public List<GiftJson> Gifts { get; set; }

        /// <summary>
        /// 是否有免邮行为
        /// </summary>
        [XmlElement("is_free_post")]
        public bool IsFreePost { get; set; }

        /// <summary>
        /// 支持的商品，多个商品用英文逗号分隔
        /// </summary>
        [XmlElement("support_items")]
        public string SupportItems { get; set; }


        /// <summary>
        /// 支持的购物车ID，多个用英文逗号分隔
        /// </summary>
        [XmlElement("support_carts")]
        public string SupportCarts { get; set; }


        /// <summary>
        /// 免邮的排除地区
        /// </summary>
        [XmlArray("exclude_areas")]
        [XmlArrayItem("exclude_area")]
        public List<YunKeyValuePair<int, string>> ExcludeArea { get; set; }


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
    }
}
