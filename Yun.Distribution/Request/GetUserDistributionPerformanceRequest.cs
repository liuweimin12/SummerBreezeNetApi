using System.Collections.Generic;
using Yun.Distribution.Response;
using Yun.Interface;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 获取登录人的分销业绩统计
    /// chenggou.distribution.performance.get
    /// </summary>
    public class GetUserDistributionPerformanceRequest : ITopRequest<GetUserDistributionPerformanceResponse>
    {
        public string GetApiName()
        {
            return "chenggou.distribution.performance.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new Dictionary<string, string>();
        }

        public void Validate()
        {

        }
    }
}
