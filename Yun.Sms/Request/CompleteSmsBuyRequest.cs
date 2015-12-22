using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    public class CompleteSmsBuyRequest : ITopRequest<BoolResultResponse>
    {

        public int OrderId { get; set; }

        public string Ip { get; set; }

        public string PayPassword { get; set; }



        public string GetApiName()
        {
            return "chenggou.sms.trade.complete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"orderid",OrderId},
                {"ip",Ip},
                {"paypassword",PayPassword}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("orderid", OrderId, 1);
            RequestValidator.ValidateRequired("ip", Ip);
        }
    }
}
