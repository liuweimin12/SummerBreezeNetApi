using System.Xml.Serialization;

namespace Yun.User
{
    public class SignStatisticsModel
    {
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        ///用户ID 
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 总签到积分
        /// </summary>
        [XmlElement("total")]
        public int Total { get; set; }

        /// <summary>
        /// 连续签到次数
        /// </summary>
        [XmlElement("continue_day")]
        public int Continueday { get; set; }

        /// <summary>
        /// 总签到次数
        /// </summary>
        [XmlElement("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 最近一次时间
        /// </summary>
        [XmlElement("last_time")]
        public string LastTime { get; set; }
    }
}
