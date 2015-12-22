using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class UpdateCartRequest : ITopRequest<BoolResultResponse>
    {
        public int CartId { get; set; }

        public int Quantity { get; set; }

        public string UserFlag { get; set; }

        public string GetApiName()
        {
            return "chenggou.shoppingcart.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cartid", CartId},
                {"quantity", Quantity},
                {"userflag",UserFlag}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cartid", CartId);
            RequestValidator.ValidateMinValue("quantity", Quantity, 0);
        }
    }
}