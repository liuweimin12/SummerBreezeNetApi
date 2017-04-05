using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 删除未绑定的店铺
    /// yun.shop.unbound.delete
    /// </summary>
    public class DeleteUnboundShopRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public string Ids { get; set; }

        public string GetApiName()
        {
            return "yun.shop.unbound.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"ids",Ids}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Ids);
        }
    }
}
