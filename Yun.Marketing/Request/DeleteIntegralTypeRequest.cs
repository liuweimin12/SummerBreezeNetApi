using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 删除积分类型
    /// yun.integral.type.delete
    /// </summary>
    public class DeleteIntegralTypeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "yun.integral.type.delete";
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
