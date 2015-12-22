using System.Xml.Serialization;
namespace Yun.Site
{
    public class MultipleInfo
    {
        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 超链接
        /// </summary>
        [XmlElement("hyper_link")]
        public string HyperLink { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 附加文字1
        /// </summary>
        [XmlElement("additional_info")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// 附加文字2
        /// </summary>
        [XmlElement("second_additional_info")]
        public string SecondAdditionalInfo { get; set; }


        /// <summary>
        /// 附加文字3
        /// </summary>
        [XmlElement("third_additional_info")]
        public string ThirdAdditionalInfo { get; set; }

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
    }
}
