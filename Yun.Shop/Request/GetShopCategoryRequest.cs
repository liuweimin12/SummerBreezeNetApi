using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Shop.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 获取单条店铺分类信息
    /// </summary>
    public class GetShopCategoryRequest : ITopRequest<GetShopCategoryResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.category.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
