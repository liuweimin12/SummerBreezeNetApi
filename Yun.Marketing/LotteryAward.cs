using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class LotteryAward
    {
        /// <summary>
        /// 自增iD
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 用户ID 
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }


        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [XmlElement("lottery_id")]
        public int LotteryId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 更新时间/中将时间
        /// </summary>
        [XmlElement("winning_time")]
        public string WinningTime { get; set; }


        /// <summary>
        /// 奖品
        /// </summary>
        [XmlElement("prize")]
        public LotteryPrize Prize { get; set; }


        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public int Status { get; set; }


        /// <summary>
        /// 领奖时间
        /// </summary>
        [XmlElement("award_time")]
        public string AwardTime { get; set; }


        /// <summary>
        /// 领奖信息
        /// </summary>
        [XmlElement("award_info")]
        public string AwardInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}
