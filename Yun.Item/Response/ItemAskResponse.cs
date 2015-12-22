using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class ItemAskResponse : YunResponse
    {
        /// <summary>
        /// 问题列表
        /// </summary>
        [XmlElement("question")]
        public ItemAsk Question { get; set; }
    }
}
