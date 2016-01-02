using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class GetRoleFunctionsRequest : ITopRequest<FunctionsResponse>   
    {
        /// <summary>
        /// 多个角色ID用英文逗号分隔
        /// </summary>
        public string RoleIds { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.role.functions.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"roleids", RoleIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("roleids", RoleIds);
        }
    }
}
