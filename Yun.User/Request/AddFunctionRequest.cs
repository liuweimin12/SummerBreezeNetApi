using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AddFunctionRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 页面名字，不能重复
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// 允许的权限（URL）集合
        /// </summary>
        public string AllowBlock { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.function.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"sort", Sort},
                {"description", Description},
                {"parentid", ParentId},
                {"url", Url},
                {"display", Display},
                {"allowblock", AllowBlock},
                {"type", Type},
                {"image", Image},
                {"companyid", CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", Name, 30);
        }
    }
}
