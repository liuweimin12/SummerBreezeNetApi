using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class RolesResponse : YunResponse
    {
        /// <summary>
        /// 返回角色数据
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public List<Roles> Roles { get; set; }
    }
}
