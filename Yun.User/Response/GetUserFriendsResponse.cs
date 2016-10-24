using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_user_friends_response")]
    public class GetUserFriendsResponse: YunResponse
    {
        /// <summary>
        /// 朋友
        /// </summary>
        [XmlArray("friends")]
        [XmlArrayItem("friend")]
        public List<Friend> Friends { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
