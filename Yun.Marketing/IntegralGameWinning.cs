using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class IntegralGameWinning
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public int RuleId { get; set; }



        /// <summary>
        /// 游戏ID
        /// </summary>
        [XmlElement("game_id")]
        public int GameId { get; set; }


        /// <summary>
        /// 自增ID
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
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 领奖信息
        /// </summary>
        [XmlElement("award_info")]
        public string AwardInfo { get; set; }


        /// <summary>
        /// 领奖时间
        /// </summary>
        [XmlElement("award_time")]
        public string AwardTime { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}
