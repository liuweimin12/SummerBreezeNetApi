using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
    [XmlRoot("get_user_distribution_performance_response")]
    public class GetUserDistributionPerformanceResponse : YunResponse
    {
        /// <summary>
        /// 分销业绩
        /// </summary>
        [XmlElement("distributor_performance")]
        public DistributorPerformance DistributorPerformance { get; set; }
    }
}
