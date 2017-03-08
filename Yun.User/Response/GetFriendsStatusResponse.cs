using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    /// <summary>
    /// 批量查询好友的状态
    /// </summary>
    [XmlRoot("get_friends_status_response")]
    public class GetFriendsStatusResponse : YunResponse
    {
        [XmlArray("friend_statuses")]
        [XmlArrayItem("friend_status")]
        public List<InviteStatus> FriendStatuses { get; set; }
    }
}
