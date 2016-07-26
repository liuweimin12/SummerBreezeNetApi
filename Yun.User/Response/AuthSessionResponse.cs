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
    }
}
