using System.Xml.Serialization;

namespace Yun.Trade
{
    public class RefundDetail
    {
        /// <summary>
        /// 退款批号
        /// </summary>
        [XmlElement("refund_batch_no")]
        public string RefundBatchNo { get; set; }

        /// <summary>
        /// 充值卡余额
        /// </summary>
        [XmlElement("prepaid_card")]
        public double PrepaidCard { get; set; }

        /// <summary>
        /// 退款号
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 订单号/子订单号
        /// </summary>
        [XmlElement("order_id")]
        public int OrderId { get; set; }

        /// <summary>
        /// 现金流退款号
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_id")]
        public int TradeId { get; set; }

        /// <summary>
        /// 退款理由
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { set; get; }

        /// <summary>
        /// 退款至余额的金额
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }

        /// <summary>
        /// 退款至线上的金额
        /// </summary>
        [XmlElement("online")]
        public double Online { get; set; }

        [XmlElement("order_info")]
        public SnapshotOrder OrderInfo { get; set; }
    }
}
