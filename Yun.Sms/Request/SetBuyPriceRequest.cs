using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    public class SetBuyPriceRequest : ITopRequest<BoolResultResponse>
    {

        /// <summary>
        /// quantity:price#quantity:price
        /// </summary>
        public string Price { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.price.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"price",Price}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("price", Price);
        }
    }
}
