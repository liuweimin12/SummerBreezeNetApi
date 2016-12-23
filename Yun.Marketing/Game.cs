using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class Game
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public int State { get; set; }

        /// <summary>
        /// 标题图片
        /// </summary>
        [XmlElement("banner")]
        public string Banner { get; set; }


        /// <summary>
        /// 游戏ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 游戏标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 游戏类型
        /// </summary>
        [XmlElement("game_type")]
        public string GameType { get; set; }


        /// <summary>
        /// 单人最多可玩次数
        /// </summary>
        [XmlElement("max_times")]
        public int MaxTimes { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

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


        /// <summary>
        /// 游戏详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 扩展自定义字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}
