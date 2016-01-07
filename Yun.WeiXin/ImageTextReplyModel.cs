
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class ImageTextReplyModel
    {
        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 简要
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        [XmlElement("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public int Sort { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }
    }
}
