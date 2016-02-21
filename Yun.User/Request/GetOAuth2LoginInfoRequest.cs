using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户快捷登录的信息
    /// chenggou.user.oauth2.get
    /// </summary>
    public class GetOAuth2LoginInfoRequest: ITopRequest<GetOAuth2LoginInfoResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.oauth2.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid",UserId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
