using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 用户的授权判断
    /// yun.permission.authorization.judgment
    /// </summary>
    public class AuthorizationJudgmentRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 访问路径
        /// </summary>
        public string AccessPath { get; set; }

        public string GetApiName()
        {
            return "yun.permission.authorization.judgment";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accesspath",AccessPath}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("accesspath", AccessPath);
        }
    }
}
