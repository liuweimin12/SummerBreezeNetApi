using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 更新公司的管理人员
    /// yun.company.management.user.update
    /// </summary>
    public class UpdateCompanyManagementRequest: ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 目标公司ID
        /// </summary>
        public int TargetCompanyId { get; set; }

        public string GetApiName()
        {
            return "yun.company.management.user.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userid", UserId},
                {"targetcompanyid", TargetCompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("userid", UserId, 1);
            RequestValidator.ValidateMinValue("targetcompanyid", TargetCompanyId, 1);
        }
    }
}
