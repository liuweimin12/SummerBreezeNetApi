using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class CustomBoxesResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("custom_boxes")]
        [XmlArrayItem("custom_box")]
        public List<CustomBox> CustomBoxes { get; set; }
    }
}
