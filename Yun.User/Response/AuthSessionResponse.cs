using Yun.Response;
using System.Xml.Serialization;

namespace Yun.User.Response
{
    public class AuthSessionResponse : YunResponse
    {
        [XmlElement("user_id")]
        public long UserId { get; set; }

        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
