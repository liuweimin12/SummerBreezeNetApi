using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class ImageTextsResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("image_texts")]
        [XmlArrayItem("image_text")]
        public List<ImageText> ImageTexts { get; set; }
    }
}
