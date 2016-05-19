using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取全局商品类目详情
    /// </summary>
    public class GetItemCatDetailRequest : ITopRequest<ItemCatResponse>
    {
        /// <summary>
        /// 分类Id
        /// </summary>
        public int ItemCatId { get; set; }

        public string GetApiName()
        {
            return "chenggou.itemcat.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemcatid", ItemCatId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemcatid", ItemCatId);
        }
    }
}
