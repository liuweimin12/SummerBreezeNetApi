using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 获取文章详情
    /// 根据文章ID获取文章详情
    /// </summary>
    public class GetArchiveRequest : ITopRequest<GetArchiveResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.get";
        }

        /// <summary>
        /// 需要返回的字段信息
        /// </summary>
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
