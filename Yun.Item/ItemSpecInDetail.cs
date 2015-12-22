using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Item
{
    public class ItemSpecInDetail
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 下面的规格值
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("value")]
        public List<ItemSpecValueInCat> Values { get; set; } 
    }
}
