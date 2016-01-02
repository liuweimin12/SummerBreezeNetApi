using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_user_tag_response")]
    public class GetUserTagResponse : YunResponse
    {
        [XmlElement("user_tag")]
        public UserTagDomain UserTag { get; set; }
    }
}
