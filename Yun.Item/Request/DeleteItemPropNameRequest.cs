using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 删除商品SPU名字
    /// </summary>
    public class DeleteItemPropNameRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 属性名ID
        /// </summary>
        public int PropNameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propname.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"propnameid", PropNameId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("propnameid", PropNameId);
        }
    }
}
