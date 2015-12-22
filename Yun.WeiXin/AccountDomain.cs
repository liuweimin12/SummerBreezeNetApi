using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class AccountDomain
    {
        /// <summary>
        /// 回掉地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// ID号
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 微信Token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 编码AES密钥
        /// </summary>
        [XmlElement("encoding_aes_key")]
        public string Encodingaeskey { get; set; }

        /// <summary>
        /// 0：订阅号，1：通过认证的订阅号/服务号，2：高级认证的服务号
        /// </summary>
        [XmlElement("level")]
        public int Level { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 账户
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 原始ID
        /// </summary>
        [XmlElement("original")]
        public string Original { get; set; }

        /// <summary>
        /// Secret
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// 是否连接
        /// </summary>
        [XmlElement("is_connect")]
        public bool Isconnect { get; set; }

        /// <summary>
        /// 二维码
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 订阅地址
        /// </summary>
        [XmlElement("subscribe_url")]
        public string SubscribeUrl { get; set; }
    }
}
