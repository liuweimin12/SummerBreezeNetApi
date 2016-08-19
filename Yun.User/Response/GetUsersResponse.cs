using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.User.Response
{
     [XmlRoot("get_users_response")]
    public class GetUsersResponse:YunResponse
    {
        [XmlArray("users")]
        [XmlArrayItem("user")]
        public List<UserDetail> Users { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
