using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_integral_rule_list_response")]
    public class GetIntegralRuleListResponse : YunResponse
    {
        [XmlArray("integral_rules")]
        [XmlArrayItem("integral_rule")]
        public List<IntegralRule> IntegralRules { get; set; }
    }
}
