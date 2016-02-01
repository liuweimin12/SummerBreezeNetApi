using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemPropNamesRequest : ITopRequest<ItemPropNamesResponse>     
    {

        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int ItemCatId { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// 特殊标记类型，可自定义，方便以后索搜用，不能超过255，最小为0
        /// </summary>
        public int? SpecialType { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propnames.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemcatid", ItemCatId},
                {"shopid",ShopId},
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"companyid",CompanyId},
                {"specialtype",SpecialType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pagenum", PageNum);
            RequestValidator.ValidateRequired("pagesize", PageSize);
        }
    }
}
