using System.Xml.Serialization;

namespace Yun.Site
{
    public class CityDomain
    {
        /// <summary>
        /// 城市id
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public int Sort { get; set; }


        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }


        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("state")]
        public int State { get; set; }


        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 下级数量
        /// </summary>
        [XmlElement("next_level_count")]
        public int NextLevelCount { get; set; }


        /// <summary>
        /// 外部ID
        /// </summary>
        [XmlElement("outer_id")]
        public int OuterId { get; set; }
    }
}
