using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class DeleteItemPropValueRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 属性值ID
        /// </summary>
        public int PropValueId { get; set; }
        public string GetApiName()
        {
            return "chenggou.item.propvalue.delete";
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
