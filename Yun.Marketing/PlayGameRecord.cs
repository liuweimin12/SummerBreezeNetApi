using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class PlayGameRecord
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }


        /// <summary>
        /// 游戏ID
        /// </summary>
        [XmlElement("game_id")]
        public int GameId { get; set; }


        /// <summary>
        /// 玩游戏时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }
    }
}
