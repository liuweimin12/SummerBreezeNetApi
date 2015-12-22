using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
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
