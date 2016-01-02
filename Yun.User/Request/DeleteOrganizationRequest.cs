using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class DeleteOrganizationRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 组织机构ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.organization.delete";
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
