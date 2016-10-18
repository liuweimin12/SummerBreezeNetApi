using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 判断用户是否存在
    /// </summary>
    public class ExistUserRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 对应Type值
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 0：用户名
        /// 1：手机号
        /// 2：邮箱
        /// 3：身份证
        /// </summary>
        public int Type { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.exist";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content", Content},
                {"type",Type}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
