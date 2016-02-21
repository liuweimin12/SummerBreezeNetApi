using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_oauth2_login_info_response")]
    public class GetOAuth2LoginInfoResponse : YunResponse
    {
        [XmlArray("user_oauth2")]
        [XmlArrayItem("users_oauth2")]
        public List<Oauth2Login> UsersOAuth2 { get; set; }
    }
}
