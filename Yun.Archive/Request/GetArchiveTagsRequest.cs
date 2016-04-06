using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 获取文章标签
    /// 获取店铺下所有文章关联的标签
    /// </summary>
    public class GetArchiveTagsRequest : ITopRequest<TagsResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.tags.get";
        }

        /// <summary>
        /// 店铺id
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }


        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"shopid",ShopId},
                {"pagesize",PageSize}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 100);
            RequestValidator.ValidateMinValue("pagesize", PageSize, 1);
        }
    }
}
