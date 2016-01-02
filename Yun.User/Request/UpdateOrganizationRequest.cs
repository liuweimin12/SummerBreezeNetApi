using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class UpdateOrganizationRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 组织机构名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public double Sort { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

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
            return "chenggou.permission.organization.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"sort",Sort},
                {"id",Id},
                {"description",Description},
                {"parentid",ParentId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 200);
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("sort", Sort);
            RequestValidator.ValidateMaxLength("description", this.Description, 2000);
            RequestValidator.ValidateRequired("parentid", ParentId);
        }
    }
}
