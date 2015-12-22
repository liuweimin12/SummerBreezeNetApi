using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class UpdateMobileRequest : ITopRequest<BoolResultResponse>
    {
        public int OrderId { get; set; }

        public string Mobile { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.mobile.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid", OrderId},
                {"mobile", Mobile}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderid", OrderId);
            RequestValidator.ValidateRequired("mobile", Mobile);
        }
    }
}
