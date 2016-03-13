using System.Xml.Serialization;

namespace Yun.Trade
{
   public class PaymentInfo
    {
        /// <summary>
        /// 资金流水ID 
        /// </summary>
        [XmlElement("flow_id")]
        public long Flowid { get; set; }

        /// <summary>
        /// 在线付款的结果
        /// </summary>
        [XmlElement("online_pay_result")]
        public OnlinePaymentInfo OnlinePayResult { get; set; }
        
        /// <summary>
        /// 余额支付
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }

        /// <summary>
        /// 在线付款金额
        /// </summary>
        [XmlElement("online_money")]
        public double OnlineMoney { get; set; }

        /// <summary>
        /// 现金支付
        /// </summary>
        [XmlElement("cash")]
        public double Cash { get; set; }

        /// <summary>
        /// 充值卡支付金额
        /// </summary>
        [XmlElement("prepaid_card")]
        public double PrepaidCard { get; set; }
    }
}
