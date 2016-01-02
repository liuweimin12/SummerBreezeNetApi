using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AllowFunctionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 当前路径
        /// </summary>
        public string Url { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.function.allow";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"url", Url}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("url", Url);
        }
    }
}
