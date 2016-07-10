using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 重置后台功能
    /// chenggou.permission.function.rest
    /// </summary>
    public class ResetFunctionsRequest :ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public int TypeId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.function.rest";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid", CompanyId},
                {"typeid", TypeId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
