using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 更改分销比例模板
    /// chenggou.distribution.template.update
    /// </summary>
    public class UpdateDistributionTemplateRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        public string Name { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.template.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"name", Name}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
