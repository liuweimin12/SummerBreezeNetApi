using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
    public class GetMySiblingDistributorsResponse: YunResponse
    {
        /// <summary>
        /// 下级分销商
        /// </summary>
        [XmlArrayItem("lower_distributor")]
        [XmlArray("lower_distributors")]
        public List<DistributionUser> LowerDistributors { get; set; }

        /// <summary>
        /// 上级
        /// </summary>
        [XmlElement("superior_distributor")]
        public DistributionUser SuperiorDistributor { get; set; }
    }
}
