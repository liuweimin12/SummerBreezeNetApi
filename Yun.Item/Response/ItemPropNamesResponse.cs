using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class ItemPropNamesResponse : YunResponse
    {
        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 属性名列表
        /// </summary>
        [XmlArray("prop_names")]
        [XmlArrayItem("prop_name")]
        public List<ItemPropName> PropNames { get; set; }
    }
}
