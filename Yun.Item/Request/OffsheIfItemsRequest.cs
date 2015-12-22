using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class OffsheIfItemsRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 商品Ids
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
