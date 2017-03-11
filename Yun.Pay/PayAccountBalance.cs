using System.Xml.Serialization;

namespace Yun.Pay
{
    public class PayAccountBalance
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNum { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("pay_account_id")]
        public int PayAccountId { get; set; }

        /// <summary>
        /// 收入方名称
        /// </summary>
        [XmlElement("pay_account_name")]
        public string PayAccountName { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 已使用的积分
        /// </summary>
        [XmlElement("has_used")]
        public double HasUsed { get; set; }

        /// <summary>
        /// 收入（0）？支出（1）
        /// </summary>
        [XmlElement("direction")]
        public int Direction { get; set; }

        /// <summary>
        /// 关联用户ID
        /// </summary>
        [XmlElement("related_pay_account_id")]
        public int RelatedPayAccountId { get; set; }

        /// <summary>
        /// 支出方名称
        /// </summary>
        [XmlElement("related_pay_account_name")]
        public string RelatedPayAccountName { get; set; }

        /// <summary>
        /// 收入结转
        /// </summary>
        [XmlElement("income_transfer")]
        public double IncomeTransfer { get; set; }

        /// <summary>
        /// 支出结转
        /// </summary>
        [XmlElement("expenditure_transfer")]
        public double ExpenditureTransfer { get; set; }


        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }
    }
}
