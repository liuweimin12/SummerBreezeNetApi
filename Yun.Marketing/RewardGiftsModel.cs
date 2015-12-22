using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class RewardGiftsModel
    {
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
        /// 折扣率
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
        /// 礼品名称
        /// </summary>
        [XmlElement("gift_name")]
        public string GiftName { get; set; }

        /// <summary>
        /// 礼品id
        /// </summary>
        [XmlElement("gift_id")]
        public int GiftId { get; set; }

        /// <summary>
        /// 是否有免邮行为
        /// </summary>
        [XmlElement("is_free_post")]
        public bool IsFreePost { get; set; }

        /// <summary>
        /// 免邮的排除地区
        /// </summary>
        [XmlElement("exclude_area")]
        public string ExcludeArea { get; set; }
    }
}
