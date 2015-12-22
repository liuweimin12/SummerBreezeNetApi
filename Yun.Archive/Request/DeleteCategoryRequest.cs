using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class DeleteCategoryRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.category.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
