using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemSpecNameRequest : ITopRequest<ItemSpecNameResponse>
    {
        /// <summary>
        /// 商品规格ID
        /// </summary>
        public int SpecNameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specname.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sepcnameid", SpecNameId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("specnameid", SpecNameId);
        }
    }
}
