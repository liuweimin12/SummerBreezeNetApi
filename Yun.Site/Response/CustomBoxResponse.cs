using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class CustomBoxResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlElement("custom_box")]
        public CustomBox CustomBox { get; set; }
    }
}
