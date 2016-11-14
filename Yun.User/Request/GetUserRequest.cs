using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户信息
    /// 根据用户名或者用户ID获取用户信息
    /// </summary>
    public class GetUserRequest : ITopRequest<UserResponse>
    {
        /// <summary>
        /// 如果输入授权，则取当前用户，否则根据用户名查找
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 用户ID 
        /// </summary>
        public int UserId { get; set; }

        
        /// <summary>
        /// 昵称类型
        /// </summary>
        public int NickType { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"nick", Nick},
                {"userid", UserId},
                {"nicktype", NickType}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
