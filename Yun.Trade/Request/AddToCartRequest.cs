using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class AddToCartRequest : ITopRequest<IntResultResponse>
    {
        public string UserFlag { get; set; }

        public int ItemId { get; set; }

        public int Quantity { get; set; }

        public int SkuId { get; set; }

        public int CartType { get; set; }

        public string Delivery { get; set; }

        public string GetApiName()
        {
            return "chenggou.shoppingcart.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"quantity", Quantity},
                {"skuid", SkuId},
                {"delivery", Delivery},
                {"userflag",UserFlag},
                {"carttype",CartType}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
            RequestValidator.ValidateMinValue("quantity", Quantity, 1);
            RequestValidator.ValidateMinValue("itemid", ItemId, 1);
            RequestValidator.ValidateMinValue("skuid", SkuId, 0);
            RequestValidator.ValidateRequired("delivery", Delivery);
        }

    }
}
