using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AddOrganizationRequest : ITopRequest<IntResultResponse>
    {
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
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.organization.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"sort",Sort},
                {"description",Description},
                {"parentid",ParentId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 200);
            RequestValidator.ValidateRequired("sort", Sort);
            RequestValidator.ValidateMaxLength("description", this.Description, 2000);
            RequestValidator.ValidateRequired("parentid", ParentId);
        }
    }
}
