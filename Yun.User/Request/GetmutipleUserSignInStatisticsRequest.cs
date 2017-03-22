using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 批量获取用户签到的统计数据
    /// yun.user.signin.mutiple.statistics.get
    /// </summary>
    public class GetmutipleUserSignInStatisticsRequest : ITopRequest<GetmutipleUserSignInStatisticsResponse>
    {
        /// <summary>
        /// 用户ID，多个用户ID使用英文逗号分隔，如果没有传入用户ID，则根据token自动匹配
        /// </summary>
        public string UsersId { get; set; }

        public string GetApiName()
        {
            return "yun.user.signin.mutiple.statistics.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"usersid", UsersId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("usersid", UsersId);
        }
    }
}
