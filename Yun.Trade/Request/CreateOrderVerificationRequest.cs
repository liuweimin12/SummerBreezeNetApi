using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 创建订单前的购买条件检测
    /// yun.order.purchase.verification
    /// </summary>
    public class CreateOrderVerificationRequest : ITopRequest<CreateOrderVerificationResponse>
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        public List<CreateOrderVerificationJson> Items { get; set; }

        public string GetApiName()
        {
            return "yun.order.purchase.verification";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"items", Items}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("items", Items);
        }
    }
}
