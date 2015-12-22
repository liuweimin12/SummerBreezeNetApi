using System.Xml.Serialization;

namespace Yun.Pay
{
    public class JsApiPayResult
    {
        /// <summary>
        /// 公众号名称，由商户传入  
        /// </summary>
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 时间戳，自1970年以来的秒数     
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// 随机串  
        /// </summary>
        [XmlElement("package")]
        public string Package { get; set; }

        /// <summary>
        /// prepay_id=预生成订单号
        /// </summary>
        [XmlElement("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("pay_sign")]
        public string PaySign { get; set; }
    }
}
