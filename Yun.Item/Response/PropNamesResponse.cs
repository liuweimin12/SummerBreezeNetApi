using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class PropNamesResponse : YunResponse
    {
        /// <summary>
        /// 属性列表，一般情况下只有一个
        /// </summary>
        [XmlArray("prop_names")]
        [XmlArrayItem("prop_name")]
        public List<ItemPropName> PropNames { get; set; }
    }
}
