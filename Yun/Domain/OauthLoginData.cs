using System.Xml.Serialization;

namespace Yun.Domain
{
    public class OauthLoginData
    {
        /// <summary>
        /// 第三方登录ID
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 第三方登录类型,qq,sinaweibo,weixin,alipay
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }
    }
}
