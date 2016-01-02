using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.User
{
    public class Employee : PermissionUser
    {
        
        /// <summary>
        /// 功能
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("function")]
        public List<Function> Functions { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public List<int> Roles { get; set; }
    }
}