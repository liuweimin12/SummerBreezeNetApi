using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetShopItemCountRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 分类的ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.item.category.getitemcount";
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
