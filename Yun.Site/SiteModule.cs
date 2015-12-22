using System.Xml.Serialization;
namespace Yun.Site
{
    public class SiteModule
    {
        [XmlElement("module_flag")]
        public string Name { get; set; }

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("module_type")]
        public string ModuleType { get; set; }

        [XmlElement("page_title")]
        public string PageTitle { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("remark")]
        public string Remark { get; set; }

        [XmlElement("thumb")]
        public string Thumb { get; set; }
    }
}
