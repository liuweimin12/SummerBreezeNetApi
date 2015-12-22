using System.Collections.Generic;
using Yun.Interface;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemSpecValueRequest : ITopRequest<ItemSpecValueInCat>   
    {
        /// <summary>
        /// 规格值ID
        /// </summary>
        public int SpecValueId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.specvalue.get";
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
