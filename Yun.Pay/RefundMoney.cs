using System.Xml.Serialization;

namespace Yun.Pay
{
    public class RefundMoney
    {
        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }

        /// <summary>
        /// 在线金额
        /// </summary>
        [XmlElement("online_money")]
        public double OnlineMoney { get; set; }

        /// <summary>
        /// 充值卡金额
        /// </summary>
        [XmlElement("prepaidcard_money")]
        public double PrepaidCardMoney { get; set; }

        /// <summary>
        /// 现金/线下金额
        /// </summary>
        [XmlElement("cash")]
        public double Cash { get; set; }
    }
}
