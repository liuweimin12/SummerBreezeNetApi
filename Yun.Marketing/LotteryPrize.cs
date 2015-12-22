using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class LotteryPrize
    {

        /// <summary>
        /// 自增ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 奖品名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 奖品等级名字
        /// </summary>
        [XmlElement("level_name")]
        public string LevelName { get; set; }


        /// <summary>
        /// 奖品等级，可当作排序用
        /// </summary>
        [XmlElement("level")]
        public int Level { get; set; }
    }
}
