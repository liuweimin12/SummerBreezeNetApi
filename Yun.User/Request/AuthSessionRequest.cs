using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 验证授权信息
    /// 根据授权信息获取用户信息
    /// </summary>
    public class AuthSessionRequest : ITopRequest<AuthSessionResponse>
    {
        public string GetApiName()
        {
            return "chenggou.user.auth";
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
