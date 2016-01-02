using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class AuthRequest : ITopRequest<AuthResponse>
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
