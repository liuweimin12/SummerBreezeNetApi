using System.Xml.Serialization;

namespace Yun.User
{
    public class SignInStatistics
    {
        /// <summary>
        /// 下次签到所得积分
        /// </summary>
        [XmlElement("next_sign_in")]
        public int NextSignIn { get; set; }

        /// <summary>
        ///用户ID 
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("username")]
        public string UserName { get; set; }

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
        /// 今日是否签到
        /// </summary>
        [XmlElement("sign_in_today")]
        public bool SignInToday { get; set; }
    }
}
