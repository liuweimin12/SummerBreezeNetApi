using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户的签到统计数据
    /// yun.user.signin.statistics.get
    /// </summary>
    public class GetUserSignInStatisticsRequest : ITopRequest<GetUserSignInStatisticsResponse>
    {
        public string GetApiName()
        {
            return "yun.user.signin.statistics.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary();
        }

        public void Validate()
        {

        }
    }
}
