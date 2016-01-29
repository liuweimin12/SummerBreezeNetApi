using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("find_rules_response")]
    public class FindRulesResponse : YunResponse
    {
        [XmlArray("rules")]
        [XmlArrayItem("rule")]
        public List<RuleDomain> Rules { get; set; }
    }
}
