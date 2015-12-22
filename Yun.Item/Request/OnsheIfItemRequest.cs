using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class OnsheIfItemRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public string ItemId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.onshelf";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid",ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
        }
    }
}
