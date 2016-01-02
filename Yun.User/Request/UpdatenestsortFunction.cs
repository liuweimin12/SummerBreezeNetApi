using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class UpdateNestsortFunction : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// id|parented|sort^ id|parented|sort
        /// </summary>
        public string SortData { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.function.updatenestsort";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sortdata", SortData}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sortdata", SortData);
            RequestValidator.ValidateMaxLength("sortdata", this.SortData, 200);
        }
    }
}
