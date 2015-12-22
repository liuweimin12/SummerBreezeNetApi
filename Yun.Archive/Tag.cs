using System.Xml.Serialization;
namespace Yun.Archive
{
    public class Tag
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }
    }
}
