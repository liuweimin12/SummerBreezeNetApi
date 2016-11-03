using System.Xml.Serialization;

namespace Yun.Pay
{
    public class AlipayAppPayParameter
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 支付宝网管
        /// </summary>
        [XmlElement("alipay_getway")]
        public string AlipayGetway { get; set; }
    }
}
