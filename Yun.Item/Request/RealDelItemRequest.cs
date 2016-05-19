using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 真删除商品
    /// </summary>
    public class RealDelItemRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 商品ID，多个用英文逗号分隔
        /// </summary>
        public string ItemId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.realdelete";
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId}
            };
            return parameters;
        }

    }
}
