using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class DeleterelationOrganizationRoleRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 角色id
        /// </summary>
        public string RoleIds { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.organization.role.deleterelation";
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
