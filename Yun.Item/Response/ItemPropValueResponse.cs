using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class ItemPropValueResponse : YunResponse
    {
        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("item_prop_value")]
        public ItemPropValue ItemPropValue { get; set; }
    }
}
