using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Item
{
    public class ItemSpecInCat
    {
       

        /// <summary>
        /// 规格名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }


        [XmlArray("values")]
        [XmlArrayItem("value")]
        public List<ItemSpecValueInCat> Values { get; set; }
    }
}
