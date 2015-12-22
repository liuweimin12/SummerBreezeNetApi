using System.Xml.Serialization;

namespace Yun.Domain
{
    public class SeoInfo
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [XmlElement("keywords")]
        public string KeyWords { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
