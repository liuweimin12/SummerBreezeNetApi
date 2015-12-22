using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class DeleteArchiveRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id }
                
            };
            return parameters;
        }

        public int Id { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
