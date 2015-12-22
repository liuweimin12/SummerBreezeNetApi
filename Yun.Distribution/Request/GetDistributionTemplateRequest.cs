using System.Collections.Generic;
using Yun.Distribution.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 获取分销等级模板
    /// chenggou.distribution.template.get
    /// </summary>
    public class GetDistributionTemplateRequest : ITopRequest<GetDistributionTemplateResponse>
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.template.get";
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
