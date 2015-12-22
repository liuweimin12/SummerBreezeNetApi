using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class MultipleInfosResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("multiple_infoes")]
        [XmlArrayItem("multiple_info")]
        public List<MultipleInfo> MultipleInfoes { get; set; }
    }
}
