using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 设为默认物流模板
    /// yun.logistics.template.default.set
    /// </summary>
    public class SetDefaultLogisticsTemplateRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 物流模板ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 是否默认
        /// </summary>
        public bool? IsDefault { get; set; }

        public string GetApiName()
        {
            return "yun.logistics.template.default.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"isdefault",IsDefault }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("id", Id, 1);
            RequestValidator.ValidateRequired("isdefault", IsDefault);
        }
    }
}
