using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class GroupBuyForItem
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

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
    }
}
