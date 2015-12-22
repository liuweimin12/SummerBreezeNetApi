using System.Xml.Serialization;

namespace Yun.Pay.PaymentIns
{
    public class WeixinConfig
    {

        /// <summary>
        /// 获取或设置合作者身份ID
        /// </summary>
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 获取或设置交易安全检验码
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 获取或设置签约支付宝账号或卖家支付宝帐户
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }


        /// <summary>
        /// 客户端通知接口
        /// </summary>
        [XmlElement("client_notify_url")]
        public string ClientNotifyUrl { get; set; }

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
    }
}
