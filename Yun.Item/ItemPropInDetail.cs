using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Item
{
    public class ItemPropInDetail
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 下面的属性值
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("value")]
        public List<ItemPropValueInDetail> Values { get; set; }
    }
}
