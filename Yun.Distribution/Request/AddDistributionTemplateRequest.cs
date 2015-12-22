using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 添加分销比例模板
    /// chenggou.distribution.template.add
    /// </summary>
    public class AddDistributionTemplateRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 模板名字
        /// </summary>
        public string Name { get; set; }



        public string GetApiName()
        {
            return "chenggou.distribution.template.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name",Name}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
