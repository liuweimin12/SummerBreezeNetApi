using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class ElementsResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("elements")]
        [XmlArrayItem("element")]
        public List<Elements> Elements { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }


    }
}
