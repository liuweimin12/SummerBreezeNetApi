using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 删除文章标签
    /// 需要授权
    /// </summary>
    public class DeleteArchiveTagRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
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
