using System.Xml.Serialization;

namespace Yun.User
{
    public class InviteStatus
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public int Status { get; set; }
    }
}
