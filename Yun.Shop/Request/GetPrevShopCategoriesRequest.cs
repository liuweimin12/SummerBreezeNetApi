using System.Collections.Generic;
using Yun.Domain;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class GetPrevShopCategoriesRequest : ITopRequest<LongKeyValuePair>
    {
        /// <summary>
        /// 分类id
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.categories.getprev";
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
        }
    }
}
