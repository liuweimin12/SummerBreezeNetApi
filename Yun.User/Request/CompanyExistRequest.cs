using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class CompanyExistRequest : ITopRequest<BoolResultResponse>
    {
        public string Content { get; set; }
        public string GetApiName()
        {
            return "chenggou.company.exist";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"content", Content}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
