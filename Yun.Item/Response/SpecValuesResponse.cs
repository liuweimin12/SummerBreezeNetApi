using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class SpecValuesResponse : YunResponse
    {
        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }


        /// <summary>
        /// 规格值列表
        /// </summary>
        [XmlArray("spec_values")]
        [XmlArrayItem("spec_value")]
        public List<ItemSpecValue> SpecValues { get; set; }
    }
}
