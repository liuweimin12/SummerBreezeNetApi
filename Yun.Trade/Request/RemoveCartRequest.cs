using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class RemoveCartRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.shoppingcart.remove";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cartids", CartIds},
                {"userflag",UserFlag}
            };

            return parameters;
        }

        public string CartIds { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cartids", CartIds);
        }

        public string UserFlag { get; set; }
    }
}
