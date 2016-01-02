using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class OrganizationsResponse : YunResponse
    {
        /// <summary>
        /// 返回组织机构数据
        /// </summary>
        [XmlArray("organizations")]
        [XmlArrayItem("organization")]
        public List<Organizations> Organizations { get; set; }
    }
}
