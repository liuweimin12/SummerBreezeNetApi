using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 删除店铺分类
    /// </summary>
    public class DeleteShopCategoryRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.category.delete";
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
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
