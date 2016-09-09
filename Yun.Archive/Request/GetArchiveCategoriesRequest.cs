using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 获取文章分类
    /// 获取文章分类列表
    /// </summary>
    public class GetArchiveCategoriesRequest : ITopRequest<GetArchiveCategoriesResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.categories.get";
        }

        /// <summary>
        /// 是否显示
        /// </summary>
        public int? Display { get; set; }

        /// <summary>
        /// 店铺id
        /// 查找某店铺下的文章
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"display", Display},
                {"shopid", ShopId},
                {"parentid", ParentId},
                {"companyid", CompanyId},
                {"categoryname", CategoryName}
            };

            return parameters;
        }

        public void Validate()
        {
        }
    }
}
