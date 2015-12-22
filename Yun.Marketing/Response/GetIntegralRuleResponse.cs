using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_integral_rule_response")]
    public class GetIntegralRuleResponse: YunResponse
    {
        [XmlElement("integral_rule")]
        public IntegralRule IntegralRule { get; set; }
    }
}
