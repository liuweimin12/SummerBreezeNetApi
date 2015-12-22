using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class DeleteTagRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }


        public string GetApiName()
        {
            return "chenggou.archive.tag.delete";
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
