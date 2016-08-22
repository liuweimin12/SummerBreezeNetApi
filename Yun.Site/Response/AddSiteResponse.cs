using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class AddSiteResponse : YunResponse
    {
        [XmlElement("token")]
        public string Token { get; set; }

        [XmlElement("user_id")]
        public int UserId { get; set; }

        [XmlElement("app_key")]
        public string AppKey { get; set; }

        [XmlElement("app_secret")]
        public string AppSecret { get; set; }
    }
}
