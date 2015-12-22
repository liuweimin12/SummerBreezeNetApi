
using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Logistics
{
    public class PostfareDetail
    {

        /// <summary>
        /// 所选择的递送方式名字
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        [XmlElement("delivery")]
        public string Delivery { get; set; }

        /// <summary>
        /// 所选择的递送方式ID
        /// </summary>
        [XmlElement("delivery_id")]
        public int DeliveryId { get; set; }

        /// <summary>
        /// 初始件数
        /// </summary>
        [XmlElement("base_quantity")]
        public int BaseQuantity { get; set; }

        /// <summary>
        /// 初始邮费，base_quantity件数量下邮费是base_price
        /// </summary>
        [XmlElement("base_price")]
        public double BasePrice { get; set; }

        /// <summary>
        /// 每增加add_quantity
        /// </summary>
        [XmlElement("add_quantity")]
        public int AddQuantity { get; set; }

        /// <summary>
        /// 每增加add_quantity，邮费增加add_price
        /// </summary>
        [XmlElement("add_price")]
        public double AddPrice { get; set; }

        [XmlArray("cities")]
        [XmlArrayItem("city")]
        public List<LongKeyValuePair> Cities { get; set; }
    }
}
