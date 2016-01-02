using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_user_tags_list_response")]
    public class GetUserTagsListResponse:YunResponse
    {
        [XmlArray("user_tags")]
        [XmlArrayItem("user_tag")]
        public List<UserTagDomain> UserTags { get; set; }
    }
}
