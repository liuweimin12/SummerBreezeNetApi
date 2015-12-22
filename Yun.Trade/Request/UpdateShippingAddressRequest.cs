using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class UpdateShippingAddressRequest : ITopRequest<BoolResultResponse>
    {

        public int OrderId { get; set; }

        public string RealName { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Zipcode { get; set; }


        public string GetApiName()
        {
            return "chenggou.trade.shippingaddress.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid", OrderId},
                {"realname", RealName},
                {"mobile", Mobile},
                {"address", Address},
                {"zipcode", Zipcode}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderid", OrderId);
            RequestValidator.ValidateRequired("realName", RealName);
            RequestValidator.ValidateRequired("mobile", Mobile);
        }
    }
}
