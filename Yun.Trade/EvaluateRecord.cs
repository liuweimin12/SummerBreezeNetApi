using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class EvaluateRecord
    {
        [XmlElement("user_avatar")]
        public string Avatar { get; set; }


        /// <summary>
        /// 商品名字
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }


        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 成交时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 所选择的SKU
        /// </summary>
        [XmlArray("Sku")]
        [XmlArrayItem("Sku")]
        public List<StringKeyValuePair> Sku { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 成长值
        /// </summary>
        [XmlElement("growing")]
        public long Growing { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("evaluate")]
        public string Evaluate { get; set; }
    }
}
