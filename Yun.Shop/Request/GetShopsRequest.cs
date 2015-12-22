using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class GetShopsRequest : ITopRequest<GetShopsResponse>
    {
        public string Ids { get; set; }

        public string Fields { get; set; }

        public string GetApiName()
        {
            return "chenggou.shops.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"ids",Ids},
               {"fields",Fields}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
            RequestValidator.ValidateMaxLength("ids",this.Ids,2000);
        }
    }
}
