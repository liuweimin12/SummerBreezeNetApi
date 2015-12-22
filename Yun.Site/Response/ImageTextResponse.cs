using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class ImageTextResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlElement("image_text")]
        public ImageText ImageText { get; set; }
    }
}
