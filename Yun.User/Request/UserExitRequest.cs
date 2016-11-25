using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 用户退出
    /// yun.user.exit
    /// </summary>
    public class UserExitRequest : ITopRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "yun.user.exit";
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
