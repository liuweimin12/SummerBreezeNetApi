using System.Xml.Serialization;
namespace Yun.Site
{
    public class OnlyText
    {
        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }

        /// <summary>
        /// 超链接
        /// </summary>
        [XmlElement("hyper_link")]
        public string HyperLink { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [XmlElement("display")]
        public bool Display { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 文本类型
        /// </summary>
        [XmlElement("text_type")]
        public int TextType { get; set; }
    }
}
