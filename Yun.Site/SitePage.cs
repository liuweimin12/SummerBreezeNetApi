using System.Xml.Serialization;

namespace Yun.Site
{
    public class SitePage
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("thumb")]
        public string Thumb { get; set; }

        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
