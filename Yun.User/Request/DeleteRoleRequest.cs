using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class DeleteRoleRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int Id { get; set; }
        public string GetApiName()
        {
            return "chenggou.permission.role.delete";
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
