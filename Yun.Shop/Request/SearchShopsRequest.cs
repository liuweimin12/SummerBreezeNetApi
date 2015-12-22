using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;

namespace Yun.Shop.Request
{
    public class SearchShopsRequest : ITopRequest<SearchShopsResponse>   
    {
        public string Fields { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }

        public int CompanyId { get; set; }

        /// <summary>
        /// 店铺名字，模糊查询
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺所在分类ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 店铺所在区域ID
        /// </summary>
        public int AreaId { get; set; }

        public string GetApiName()
        {
            return "chenggou.shops.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"shopname",ShopName},
                {"categoryid",CategoryId},
                {"areaid",AreaId},
                {"companyid",CompanyId},
               {"fields",Fields}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
