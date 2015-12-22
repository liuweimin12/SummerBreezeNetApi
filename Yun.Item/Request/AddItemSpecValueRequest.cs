using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class AddItemSpecValueRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品规格名ID
        /// </summary>
        public int SpecNameId { get; set; }

        /// <summary>
        /// 规格值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }


        public string GetApiName()
        {
            return "chenggou.item.specvalue.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"specnameid", SpecNameId},
                {"value", Value},
                {"sort",Sort}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("specnameid", SpecNameId);
            RequestValidator.ValidateRequired("value", Value);
            RequestValidator.ValidateMaxLength("value", this.Value, 200);
        }
    }
}
