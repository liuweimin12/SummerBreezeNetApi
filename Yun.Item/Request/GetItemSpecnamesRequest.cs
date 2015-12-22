using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemSpecnamesRequest : ITopRequest<SpecNamesResponse>
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

        public string GetApiName()
        {
            return "chenggou.item.specnames.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemcatid", ItemCatId},
                {"shopid",ShopId},
                {"pagenum",PageNum},
                {"pagesize",PageSize}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemcatid", ItemCatId);
            RequestValidator.ValidateRequired("shopid", ShopId);
            RequestValidator.ValidateRequired("pagenum", PageNum);
            RequestValidator.ValidateRequired("pagesize", PageSize);
        }
    }
}
