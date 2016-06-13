using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 下架商品
    /// </summary>
    public class OffsheIfItemsRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 商品Ids，多个用英文逗号分隔
        /// </summary>
        public string ItemIds { get; set; }

        public string GetApiName()
        {
            return "chenggou.items.offshelf";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemids",ItemIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemids",ItemIds);
        }
    }
}
