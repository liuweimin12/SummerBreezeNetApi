using System.Xml.Serialization;
namespace Yun.Site
{
    public class Elements
    {
        //功能名字
        [XmlElement("module_name")]
        public string ModuleName { get; set; }


        //元素ID
        [XmlElement("id")]
        public long Id { get; set; }


        //元素标题
        [XmlElement("text")]
        public string Text { get; set; }

        //类型
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [XmlElement("display")]
        public bool Display { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public int ParentId { get; set; }

        [XmlElement("module_flag")]
        public string ModuleFlag { get; set; }

    }
}
