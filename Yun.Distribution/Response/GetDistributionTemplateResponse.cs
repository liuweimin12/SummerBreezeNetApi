using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
    public class GetDistributionTemplateResponse : YunResponse
    {
        [XmlElement("distribution_template")]
        public DistributionTemplate DistributionTemplate { get; set; }
    }
}
