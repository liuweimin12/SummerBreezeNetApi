using System.Xml.Serialization;

namespace Yun.Pay.PaymentIns
{
    public class UnionPayConfig
    {
        /// <summary>
        /// 签名证书路径
        /// </summary>
        [XmlElement("sign_cert_path")]
        public string SignCertPath { get; set; }

        /// <summary>
        /// 签名证书密码
        /// </summary>
        [XmlElement("sign_cert_pwd")]
        public string SignCertPwd { get; set; }


        /// <summary>
        /// 加密证书路径
        /// </summary>
        [XmlElement("encrypt_cert_path")]
        public string EncryptCertPath { get; set; }

        /// <summary>
        /// 获取或设置合作者身份ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

    }
}
