using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 获取文章标签
    /// yun.archive.tag.get
    /// </summary>
    public class GetArchiveTagRequest : ITopRequest<GetArchiveTagResponse>
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        public int TagId { get; set; }

        /// <summary>
        /// 分类名称的缩写
        /// </summary>
        public string Slug { get; set; }

        public string GetApiName()
        {
            return "yun.archive.tag.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tagid", TagId },
                {"slug",Slug }
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
