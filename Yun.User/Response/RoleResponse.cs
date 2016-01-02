using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class RoleResponse : YunResponse
    {
        /// <summary>
        /// 角色信息
        /// </summary>
        [XmlElement("role")]
        public Roles Role { get; set; }
    }
}
