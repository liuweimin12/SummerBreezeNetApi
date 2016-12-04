using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AddRoleRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 角色类型
        /// </summary>
        public int RoleType { get; set; }

        /// <summary>
        /// 页面名字，不能重复
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public double Sort { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.role.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"sort",Sort},
                {"description",Description},
                {"roletype",RoleType},
                {"shopid",ShopId},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", Name, 200);
            RequestValidator.ValidateRequired("sort", Sort);
            RequestValidator.ValidateMaxLength("description", Description, 2000);
        }
    }
}
