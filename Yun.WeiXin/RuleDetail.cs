using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class RuleDetail
    {
        [XmlElement("rule_id")]
        public int RuleId { get; set; }

        [XmlElement("rule_name")]
        public string Name { get; set; }

        [XmlElement("display_order")]
        public int DisplayOrder { get; set; }

        [XmlElement("status")]
        public int Status { get; set; }

        [XmlArray("keywords")]
        [XmlArrayItem("keyword")]
        public List<KeywordType> Keywords { get; set; }
    }
}
