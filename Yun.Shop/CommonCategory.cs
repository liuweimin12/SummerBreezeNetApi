using System.Xml.Serialization;
namespace Yun.Shop
{
    public class CommonCategory
    {
        /// <summary>
        /// 文章id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }


        [XmlElement("display")]
        public bool Display { get; set; }

    }
}
