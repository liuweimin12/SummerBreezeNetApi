using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class GetRoleRequest : ITopRequest<RoleResponse>    
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.role.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
