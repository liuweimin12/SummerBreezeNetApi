using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.User
{
    public class Friend
    {
        /// <summary>
        /// 关系创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 好友数据
        /// </summary>
        [XmlElement("friend_info")]
        public UserDetail FriendInfo { get; set; }
    }
}
