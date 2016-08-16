using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 搜索商户
    /// </summary>
    public class SearchShopsRequest : ITopRequest<SearchShopsResponse>   
    {
        /// <summary>
        /// 需要返回的字段
        /// </summary>
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

        /// <summary>
        /// 认证状态
        /// </summary>
        public int? CertificationStatus { get; set; }


        /// <summary>
        /// 是否启用
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 最小的创建时间
        /// </summary>
        public long MinCreateTime { get; set; }

        /// <summary>
        /// 最大的创建时间
        /// </summary>
        public long MaxCreateTime { get; set; }

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
                {"shopname", ShopName},
                {"categoryid", CategoryId},
                {"areaid", AreaId},
                {"companyid", CompanyId},
                {"fields", Fields},
                {"mincreatetime", MinCreateTime},
                {"maxcreatetime", MaxCreateTime},
                {"isenabled", IsEnabled},
                {"certificationstatus", CertificationStatus}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
