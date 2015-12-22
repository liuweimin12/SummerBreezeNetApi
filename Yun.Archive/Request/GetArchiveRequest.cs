using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class GetArchiveRequest : ITopRequest<ArchiveDetailResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.get";
        }

        public string Fields { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id },
                {"fields",Fields}
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
