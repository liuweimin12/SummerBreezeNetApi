using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class ItemSpecNameResponse : YunResponse
    {
        /// <summary>
        /// 规格名
        /// </summary>
        [XmlElement("item_spec_name")]
        public ItemSpecName ItemSpecName { get; set; }
    }
}
