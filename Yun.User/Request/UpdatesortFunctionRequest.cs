using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class UpdateSortFunctionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 排序
        /// </summary>
        public double Sort { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.function.updatesort";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sort", Sort},
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("sort", Sort);
        }
    }
}
