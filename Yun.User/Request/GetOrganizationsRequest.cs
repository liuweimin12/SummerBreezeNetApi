using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class GetOrganizationsRequest : ITopRequest<OrganizationsResponse>
    {

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }


        public string GetApiName()
        {
            return "chenggou.permission.organizations.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
