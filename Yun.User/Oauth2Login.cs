
using System.Xml.Serialization;

namespace Yun.User
{
    public class Oauth2Login
    {
        /// <summary>
        /// 快捷登录类型
        /// </summary>
        [XmlElement("oauth2_type")]
        public string Oauth2Type { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 快捷登录信息
        /// </summary>
        [XmlElement("oauth2_user_info")]
        public string Oauth2UserInfo { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("oauth_id")]
        public string OauthId { get; set; }
    }
}
