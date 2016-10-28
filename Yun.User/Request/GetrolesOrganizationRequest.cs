using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class GetRolesOrganizationRequest : ITopRequest<RolesResponse>     
    {
        /// <summary>
        /// 组织机构ID
        /// </summary>
        public int OrganizationId { get; set; }
        public string GetApiName()
        {
            return "chenggou.permission.organization.getroles";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"organizationid", OrganizationId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("organizationid", OrganizationId);
        }
    }
}
