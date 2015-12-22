using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 删除分销等级模板
    /// chenggou.distribution.template.delete
    /// </summary>
    public class DeleteDistributionTemplateRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.template.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
