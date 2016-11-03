
using System.Xml.Serialization;

namespace Yun.Pay.PaymentIns
{
    public class AlipayConfig
    {
        /// <summary>
        /// 公钥
        /// </summary>
        [XmlElement("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// 秘密密钥
        /// </summary>
        [XmlElement("secret_key")]
        public string SecretKey { get; set; }


        /// <summary>
        /// 获取或设置合作者身份ID
        /// </summary>
        [XmlElement("partner")]
        public string Partner { get; set; }

        /// <summary>
        /// 获取或设置交易安全检验码
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 获取或设置签约支付宝账号或卖家支付宝帐户
        /// </summary>
        [XmlElement("seller_email")]
        public string SellerEmail { get; set; }

        /// <summary>
        /// 客户端通知接口
        /// </summary>
        [XmlElement("client_notify_url")]
        public string ClientNotifyUrl { get; set; }

        /// <summary>
        /// 客户端退款通知接口
        /// </summary>
        [XmlElement("client_refund_notify_url")]
        public string ClientRefundNotifyUrl { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("app_id")]
        public string AppId { get; set; }

    }
}
