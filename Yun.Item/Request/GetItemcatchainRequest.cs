using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemCatChainRequest : ITopRequest<ItemCatsResponse>
    {
        /// <summary>
        /// 最小分类Id
        /// </summary>
        public int ItemCatId { get; set; }

        public string GetApiName()
        {
            return "chenggou.itemcat.chain.get";
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
