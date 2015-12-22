using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class DeleteItemRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 商品名ID
        /// </summary>
        public string ItemId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
        }
    }
}
