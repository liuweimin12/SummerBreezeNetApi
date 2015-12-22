using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
    [XmlRoot("get_distribution_level_list_response")]
    public class GetDistributionLevelListResponse:YunResponse
    {
        [XmlArray("distribution_levels")]
        [XmlArrayItem("distribution_level")]
        public List<DistributionLevelDomain> DistributionLevels { get; set; }
    }
}
