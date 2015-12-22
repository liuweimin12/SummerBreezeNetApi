using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Item
{
    public class ItemPropInCat
    {
        
        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否多属性值
        /// </summary>
        [XmlElement("has_multi_values")]
        public bool HasMultiValues { get; set; }

        /// <summary>
        /// 是否必须
        /// </summary>
        [XmlElement("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// 是否可以自定义
        /// </summary>
        [XmlElement("can_custom_value")]
        public bool CanCustomValue { get; set; }


        /// <summary>
        /// 下面的属性值
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("value")]
        public List<ItemPropValueInCat> Values { get; set; }
    }
}
