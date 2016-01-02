using System;
using System.Xml.Serialization;

namespace Yun.User
{
    [Serializable]
    public class AuthorizeUrl
    {
        /// <summary>
        /// OAuth2认证类型
        /// </summary>
        [XmlElement("oauth2_type")]
        public string OAuth2Type { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }
    }
}
