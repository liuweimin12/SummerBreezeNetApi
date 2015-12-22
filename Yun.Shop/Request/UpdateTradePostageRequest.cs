using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class UpdateTradePostageRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 主订单编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 邮费价格(邮费单位是元）
        /// </summary>
        public double Postfee { get; set; }
        public string GetApiName()
        {
            return "chenggou.seller.trade.postage.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"postfee", Postfee}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("psotfee", Postfee);
        }
    }
}
