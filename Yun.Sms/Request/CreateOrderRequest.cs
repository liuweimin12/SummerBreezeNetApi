using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    public class CreateOrderRequest : ITopRequest<IntResultResponse>
    {
        ///<summary>
        /// 购买的数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 付款单号，全局唯一
        /// </summary>
        public string TradeNum { get; set; }


        public string GetApiName()
        {
            return "chenggou.sms.buy";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"quantity",Quantity},
                {"tradenum",TradeNum}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("tradenum", TradeNum);
            RequestValidator.ValidateMinValue("quantity", Quantity, 1);
        }
    }
}
