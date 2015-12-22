using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Private.Response
{

    public class LoginResponse : YunResponse
    {
        [XmlElement("token")]
        public string Token { get; set; }

        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
