using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 删除商品规格值
    /// </summary>
    public class DeleteItemSpecValueRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 规格值ID
        /// </summary>
        public int SpecValueId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specvalue.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"specvalueid", SpecValueId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("specvalueid", SpecValueId);
        }
    }
}
