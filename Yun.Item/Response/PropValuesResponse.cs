using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class PropValuesResponse : YunResponse
    {
        /// <summary>
        /// 属性值列表
        /// </summary>
        [XmlArray("prop_values")]
        [XmlArrayItem("prop_value")]
        public List<ItemPropValue> PropValues { get; set; }


        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
