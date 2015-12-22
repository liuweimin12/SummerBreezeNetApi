using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class AddItemSpecNameRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int ItemCatId { get; set; }

        /// <summary>
        /// 规格名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specname.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemcatid", ItemCatId},
                {"name", Name},
                {"shopid",ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemcatid", ItemCatId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 2000);
            RequestValidator.ValidateRequired("shopid", ShopId);
        }
    }
}
