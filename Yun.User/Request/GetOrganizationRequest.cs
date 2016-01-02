using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class GetOrganizationRequest : ITopRequest<OrganizationResponse>
    {
        /// <summary>
        /// 组织机构ID
        /// </summary>
        public int Id { get; set; }
        public string GetApiName()
        {
            return "chenggou.permission.organization.get";
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
