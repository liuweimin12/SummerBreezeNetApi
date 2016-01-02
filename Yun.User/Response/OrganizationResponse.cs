using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class OrganizationResponse : YunResponse
    {
        /// <summary>
        /// 返回组织机构数据
        /// </summary>
        [XmlElement("organization")]
        public Organizations Organization { get; set; }
    }
}
