using System.Xml.Serialization;

namespace Yun.Pay
{
    public class OuterRefund
    {
        /// <summary>
        /// 详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public int State { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }

        /// <summary>
        /// 退款ID
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 退款类型
        /// </summary>
        [XmlElement("refund_code")]
        public string RefundCode { get; set; }

        /// <summary>
        /// 支付订单号
        /// </summary>
        [XmlElement("payment_order_num")]
        public long PaymentOrderNum { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
