using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class UsersRespons : YunResponse, IPageResponse
    {
        [XmlArray("employees")]
        [XmlArrayItem("employee")]
        public List<PermissionUser> Users { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
