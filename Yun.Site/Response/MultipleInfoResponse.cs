using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class MultipleInfoResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlElement("multiple_info")]
        public MultipleInfo MultipleInfo { get; set; }
    }
}
