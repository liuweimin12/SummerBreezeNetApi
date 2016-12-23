using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class Lottery
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public int State { get; set; }


        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }


        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }



        [XmlArray("prizes")]
        [XmlArrayItem("prize")]
        public List<LotteryPrize> Prizes { get; set; }

        /// <summary>
        /// 规则的自增ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }


        /// <summary>
        /// 游戏ID
        /// </summary>
        [XmlElement("game_id")]
        public int GameId { get; set; }


        /// <summary>
        /// 最多获奖
        /// </summary>
        [XmlElement("max_award")]
        public int MaxAward { get; set; }


        /// <summary>
        /// 最多游戏次数
        /// </summary>
        [XmlElement("max_play_times")]
        public int MaxPlayTimes { get; set; }


        /// <summary>
        /// 每天最多允许的抽奖次数
        /// </summary>
        [XmlElement("max_times_per_day")]
        public int MaxTimesPerDay { get; set; }


        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}