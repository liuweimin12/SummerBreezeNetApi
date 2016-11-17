using Yun.Response;
using System.Xml.Serialization;

namespace Yun.User.Response
{
    public class AuthSessionResponse : YunResponse
    {
        [XmlElement("userid")]
        public long UserId { get; set; }

        [XmlElement("username")]
        public string UserName { get; set; }

        /// <summary>
        /// 登录信息
        /// </summary>
        [XmlElement("login_record")]
        public LoginRecord LoginRecord { get; set; }

        /// <summary>
        /// 其他用户已登录
        /// </summary>
        [XmlElement("other_user_logged_in")]
        public bool OtherUserLoggedIn { get; set; }
    }
}
