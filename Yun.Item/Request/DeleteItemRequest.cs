using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 删除商品，放入回收站
    /// </summary>
    public class DeleteItemRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 商品名ID，多个商品用英文逗号分隔
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
