using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class TextResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlElement("text")]
        public OnlyText Text { get; set; }
    }
}
