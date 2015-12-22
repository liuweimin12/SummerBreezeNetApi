using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class ItemPropNameResponse : YunResponse
    {
        /// <summary>
        /// 属性名
        /// </summary>
        [XmlElement("item_prop_name")]
        public ItemPropName ItemPropName { get; set; }
    }
}
