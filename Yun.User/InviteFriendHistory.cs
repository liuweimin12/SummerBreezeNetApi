using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.User
{
    public class InviteFriendHistory
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 邀请人用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 目标用户ID
        /// </summary>
        [XmlElement("target_user_id")]
        public int TargetUserId { get; set; }


        /// <summary>
        /// 目标对象信息
        /// </summary>
        [XmlElement("target_user_info")]
        public UserDetail TargetUserInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public int State { get; set; }
    }
}
