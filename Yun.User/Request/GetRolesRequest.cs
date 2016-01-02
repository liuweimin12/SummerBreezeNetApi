using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class GetRolesRequest : ITopRequest<RolesResponse>  
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        public int? RoleType { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.roles.get";
        }


        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary
            {
                {"shopid", ShopId},
                {"roletype",RoleType},
                {"companyid",CompanyId}
            };
        }

        public void Validate()
        {
        }
    }
}
