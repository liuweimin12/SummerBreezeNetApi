using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    /// <summary>
    /// 获取邀请朋友的列表
    /// </summary>
    [XmlRoot("get_invite_friends_list_response")]
    public class GetInviteFriendsListResponse : YunResponse
    {
        /// <summary>
        /// 已发送邀请关系
        /// </summary>
        [XmlArray("invite_friend_histories")]
        [XmlArrayItem("invite_friend_history")]
        public List<InviteFriendHistory> InviteFriendHistories { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
