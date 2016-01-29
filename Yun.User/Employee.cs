using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.User
{
    public class Employee : PermissionUser
    {

        /// <summary>
        /// 该人员所拥有的权限
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("function")]
        public List<Function> Functions { get; set; }

        /// <summary>
        /// 该人员所拥有的角色
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public List<LongKeyValuePair> Roles { get; set; }


    }
}