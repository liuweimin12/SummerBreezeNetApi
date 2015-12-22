

using System.Xml.Serialization;

namespace Yun.Pay.PaymentIns
{
    public class BocPayConfig
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
        /// 商户号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

    }
}
