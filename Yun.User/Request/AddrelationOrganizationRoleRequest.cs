using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AddRelationOrganizationRoleRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 组织机构ID
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// 角色ID,不同角色用英文逗号进行分割
        /// </summary>
        public string RoleIds { get; set; }


        public string GetApiName()
        {
            return "chenggou.permission.organization.role.addrelation";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"organizationid", OrganizationId},
                {"roleids",RoleIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("organizationid", OrganizationId);
            RequestValidator.ValidateRequired("roleids", RoleIds);
            RequestValidator.ValidateMaxLength("roleids", this.RoleIds, 2000);
        }
    }
}
