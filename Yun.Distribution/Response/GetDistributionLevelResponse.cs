using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
    [XmlRoot("get_distribution_level_response")]
    public class GetDistributionLevelResponse:YunResponse
    {
        [XmlElement("distribution_level")]
        public DistributionLevelDomain DistributionLevel { get; set; }
    }
}
