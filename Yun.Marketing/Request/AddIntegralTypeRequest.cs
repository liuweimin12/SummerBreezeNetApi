using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 新增积分类型
    /// yun.integral.type.add
    /// </summary>
    public class AddIntegralTypeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型标识
        /// </summary>
        public string TypeFlag { get; set; }

        public string GetApiName()
        {
            return "yun.integral.type.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"typeflag", TypeFlag}
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
