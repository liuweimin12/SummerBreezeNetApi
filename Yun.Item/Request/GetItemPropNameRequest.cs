using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemPropNameRequest : ITopRequest<ItemPropNameResponse>   
    {
        /// <summary>
        /// 商品属性ID
        /// </summary>
        public int PropNameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propname.get";
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
