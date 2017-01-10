using System.Xml.Serialization;

namespace Yun.User
{
    public class SourcesOfExpenditure
    {
        /// <summary>
        /// 收入备注
        /// </summary>
        [XmlElement("income_remark")]
        public string IncomeRemark { get; set; }

        /// <summary>
        /// 支出备注
        /// </summary>
        [XmlElement("expenditure_remark")]
        public string ExpenditureRemark { get; set; }

        /// <summary>
        /// 收入详情
        /// </summary>
        [XmlElement("income_detail")]
        public string IncomeDetail { get; set; }

        /// <summary>
        /// 支出详情
        /// </summary>
        [XmlElement("expenditure_detail")]
        public string ExpenditureDetail { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("expenditure_user_id")]
        public int ExpenditureUserId { get; set; }


        /// <summary>
        /// 收入人ID
        /// </summary>
        [XmlElement("income_user_id")]
        public int IncomeUserId { get; set; }


        /// <summary>
        /// 支出ID
        /// </summary>
        [XmlElement("expenditure_id")]
        public int ExpenditureId { get; set; }

        /// <summary>
        /// 收入ID
        /// </summary>
        [XmlElement("income_id")]
        public int IncomeId { get; set; }


        /// <summary>
        /// 积分
        /// </summary>
        [XmlElement("score")]
        public int Score { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("income_type")]
        public string IncomeType { get; set; }

        /// <summary>
        /// 支出类型
        /// </summary>
        [XmlElement("expenditure_type")]
        public string ExpenditureType { get; set; }

        /// <summary>
        /// 支出时间
        /// </summary>
        [XmlElement("expenditure_time")]
        public string ExpenditureTime { get; set; }
    }
}
