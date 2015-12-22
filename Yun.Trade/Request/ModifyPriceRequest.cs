using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class ModifyPriceRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// id,price#id,price
        /// 子订单ID,该订单价格#子订单ID,该订单价格
        /// #字符代表多订单的重复
        /// </summary>
        public string Price { get; set; }

        public double Postfee { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.price.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"price", Price},
                {"postfee", Postfee}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("postfee", Postfee);
            RequestValidator.ValidateMinValue("postfee", Postfee, 0);
            RequestValidator.ValidateRequired("price", Price);
        }
    }
}
