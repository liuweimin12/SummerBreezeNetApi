using System;
using System.Xml.Serialization;

namespace Yun.User
{
    [Serializable]
    public class OAuth2Setting
    {
        /// <summary>
        /// 客户端ID
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        [XmlElement("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }
    }
}
