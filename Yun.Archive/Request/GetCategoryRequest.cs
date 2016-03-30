using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 获取文章分类
    /// 根据分类ID来查找文章分类
    /// </summary>
    public class GetCategoryRequest : ITopRequest<ArchiveCategoryResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.category.get";
        }

        public int Id { get; set; }

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
