using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class UpdateShopItemCategoryDisplayRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 文章的ID值
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }
        
        public string GetApiName()
        {
            return "chenggou.shop.item.category.updatedisplay";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"display",Display}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("display",Display);
        }
    }
}
