using System.Xml.Serialization;

namespace Yun.User
{
    public class SourcesOfExpenditure
    {
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
