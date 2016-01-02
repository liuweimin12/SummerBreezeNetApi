using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class SavesRelationOrganizationRoleRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 组织机构ID
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// 多个角色ID用英文逗号分隔
        /// </summary>
        public string RoleIds { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.organization.role.savesrelation";
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
