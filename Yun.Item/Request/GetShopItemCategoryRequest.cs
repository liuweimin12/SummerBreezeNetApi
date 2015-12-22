using System.Collections.Generic;
using Yun;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace CgApi.Shop.Request
{
    public class GetShopItemCategoryRequest : ITopRequest<CategoryResponse>
    {
        /// <summary>
        /// 文章的ID值
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.item.category.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
