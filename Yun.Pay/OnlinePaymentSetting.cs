using System.Xml.Serialization;
using Yun.Pay.PaymentIns;

namespace Yun.Pay
{
    public class OnlinePaymentSetting
    {
        /// <summary>
        /// 支付宝设置信息
        /// 合作者身份ID,交易安全检验码,支付宝账号或卖家支付宝帐户,ReturnUrl,NotifyUrl
        /// </summary>
        [XmlElement("alipay")]
        public AlipayConfig Alipay { get; set; }


        [XmlElement("union_pay")]
        public UnionPayConfig UnionPay { get; set; }

        /// <summary>
        /// 财付通设置信息
        /// BargainorId,Key,ReturnUrl,NotifyUrl
        /// </summary>
        [XmlElement("tenpay")]
        public TenPayConfig Tenpay { get; set; }

        /// <summary>
        /// 中行快付
        /// </summary>
        [XmlElement("bocpay")]
        public BocPayConfig Bocpay { get; set; }


        [XmlElement("weixinpay")]
        public WeixinConfig Weixinpay { get; set; }

        /// <summary>
        /// 选用哪家网银直连
        /// </summary>
        [XmlElement("banking_direct_connect")]
        public string BankingDirectConnect { get; set; }


        /// <summary>
        /// 支持哪些付款方式
        /// </summary>
        [XmlElement("payment_code")]
        public string PaymentCode { get; set; }

        /// <summary>
        /// 盛付通设置信息
        /// MsgSender,Key,ReturnUrl,NotifyUrl
        /// </summary>
        [XmlElement("shengpay")]
        public ShengPayConfig Shengpay { get; set; }

        /// <summary>
        /// 是否用自己的第三方支付手段
        /// </summary>
        [XmlElement("use_self")]
        public bool UseSelf { get; set; }
    }
}
