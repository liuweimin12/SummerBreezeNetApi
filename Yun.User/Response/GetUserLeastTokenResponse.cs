using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_user_least_token_response")]
    public class GetUserLeastTokenResponse : YunResponse
    {
        /// <summary>
        /// 用户的token
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        [XmlElement("login_time")]
        public string LoginTime { get; set; }
    }
}
