using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
    public class GetDistributionTemplateListResponse : YunResponse
    {
        [XmlArray("distribution_templates")]
        [XmlArrayItem("distribution_template")]
        public List<DistributionTemplate> DistributionTemplates { get; set; }
    }
}
