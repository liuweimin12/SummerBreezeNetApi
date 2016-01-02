using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class DeleteEmployeeRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 子帐号ID
        /// </summary>
        public int Id { get; set; }
        public string GetApiName()
        {
            return "chenggou.permission.user.delete";
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
