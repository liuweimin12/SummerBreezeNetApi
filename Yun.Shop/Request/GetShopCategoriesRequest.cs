using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Shop.Response;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 获取所有店铺分类信息
    /// </summary>
    public class GetShopCategoriesRequest : ITopRequest<GetShopCategoriesResponse>
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        public int? ParentId { get; set; }
        public string GetApiName()
        {
            return "chenggou.shop.categories.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"parentid", ParentId}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
