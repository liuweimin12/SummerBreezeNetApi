using System.Xml.Serialization;

namespace Yun.Trade
{
    public class OnlinePaymentInfo
    {
        /// <summary>
        /// 支付商的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 在线付款金额
        /// </summary>
        [XmlElement("online")]
        public double Online { get; set; }

        /// <summary>
        /// 第三方支付代码/名字
        /// </summary>
        [XmlElement("pay_code")]
        public string PayCode { get; set; }

        /// <summary>
        /// 银行代码
        /// </summary>
        [XmlElement("pay_bank")]
        public string PayBank { get; set; }


        /// <summary>
        /// 支付渠道，用来区分信用卡和储蓄卡支付
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 支付商的交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
