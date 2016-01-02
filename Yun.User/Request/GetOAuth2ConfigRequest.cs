using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class GetOAuth2ConfigRequest : ITopRequest<GetOAuth2ConfigResponse>
    {
        /// <summary>
        /// OAuth2认证类型
        /// </summary>
        public string OAuth2Type { get; set; }

        public string GetApiName()
        {
            return "chenggou.oauth2.config.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary
            {
                {"oauth2type",OAuth2Type}
            };
        }

        public void Validate()
        {
        }
    }
}
