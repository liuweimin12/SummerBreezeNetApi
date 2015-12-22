using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class TextsResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("texts")]
        [XmlArrayItem("text")]
        public List<OnlyText> Texts { get; set; }
    }
}
