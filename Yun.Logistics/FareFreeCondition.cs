using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Logistics
{
    public class FareFreeCondition
    {
        /// <summary>
        /// 递送方式的ID
        /// </summary>
        [XmlElement("delivery_id")]
        public int DeliveryId { get; set; }

        [XmlArray("cities")]
        [XmlArrayItem("city")]
        public List<LongKeyValuePair> Cities { get; set; }

        /// <summary>
        /// 包邮条件
        /// </summary>
        [XmlElement("free_type")]
        public int FreeType { get; set; }

        /// <summary>
        /// XX元以上免费
        /// </summary>
        [XmlElement("price")]
        public double Price { get; set; }

        /// <summary>
        /// 在XX内免费
        /// </summary>
        [XmlElement("preferential")]
        public double Preferential { get; set; }
    }
}
