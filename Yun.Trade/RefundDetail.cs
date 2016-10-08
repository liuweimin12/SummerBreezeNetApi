using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class RefundDetail
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [XmlElement("exchange_rate")]
        public ExchangeRate ExchangeRate { get; set; }

        /// <summary>
        /// 退款件数
        /// </summary>
        [XmlElement("refund_quantity")]
        public int RefundQuantity { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 店铺名字
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 退款批号
        /// </summary>
        [XmlElement("refund_batch_no")]
        public string RefundBatchNo { get; set; }

        /// <summary>
        /// 需要退款的充值卡金额
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

        /// <summary>
        /// 退款历史记录
        /// </summary>
        [XmlArray("refund_histories")]
        [XmlArrayItem("refund_history")]
        public List<RefundHistory> RefundHistories { get; set; }

        [XmlElement("order_info")]
        public SnapshotOrder OrderInfo { get; set; }

        /// <summary>
        /// 现金的退款金额
        /// </summary>
        [XmlElement("cash")]
        public double Cash { get; set; }

    }
}
