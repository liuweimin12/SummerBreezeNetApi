
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class RuleDomain
    {
        [XmlElement("rule_id")]
        public int Id { get; set; }

        [XmlElement("account_id")]
        public int AccountId { get; set; }

        [XmlElement("rule_name")]
        public string Name { get; set; }

        [XmlElement("display_order")]
        public int DisplayOrder { get; set; }

        [XmlElement("status")]
        public int Status { get; set; }
    }
}
