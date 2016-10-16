using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetPrevsShopItemCategoryRequest : ITopRequest<GetCategoryPrevsResponse>
    {
        /// <summary>
        /// 文章的ID值
        /// </summary>
        public int Id { get; set; }

        public int ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.item.category.getprevs";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"shopid",ShopId }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
