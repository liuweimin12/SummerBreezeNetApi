using System.Xml.Serialization;
namespace Yun.Archive
{
    public class ArticleCategory
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
         [XmlElement("display")]
        public bool Display { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
         [XmlElement("parentid")]
        public long  ParentId { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
         [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 统计
        /// </summary>
         [XmlElement("count")]
        public long  Count { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
         [XmlElement("sort")]
        public long  Sort { get; set; }

        /// <summary>
        /// id
        /// </summary>
         [XmlElement("id")]
        public long  Id { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
         [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }


        /// <summary>
        /// 分类的缩写，唯一
        /// </summary>
        [XmlElement("slug")]
        public string Slug { get; set; }
    }
}
