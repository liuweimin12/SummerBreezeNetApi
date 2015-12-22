using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Trade
{
    public class TradeRecord
    {
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 成交时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 商品名字
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 所选择的SKU
        /// </summary>
        [XmlElement("total_item")]
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
        /// 扩展值
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}
