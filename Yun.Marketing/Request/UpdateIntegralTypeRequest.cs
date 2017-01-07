using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 新增积分类型
    /// yun.integral.type.update
    /// </summary>
    public class UpdateIntegralTypeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型标识
        /// </summary>
        public string TypeFlag { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "yun.integral.type.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"typeflag", TypeFlag},
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("typeflag", TypeFlag);
        }
    }
}
