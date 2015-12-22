using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemPropValueRequest : ITopRequest<ItemPropValueResponse>
    {
        /// <summary>
        /// 属性值ID
        /// </summary>
        public int PropValueId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propvalue.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"propvalueid", PropValueId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("propvalueid", PropValueId);
        }
    }
}
