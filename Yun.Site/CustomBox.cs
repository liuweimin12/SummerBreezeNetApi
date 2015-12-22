using System.Xml.Serialization;
namespace Yun.Site
{
    public class CustomBox
    {
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
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 自定义内容
        /// </summary>
        [XmlElement("custom_text")]
        public string CustomText { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }
    }
}
