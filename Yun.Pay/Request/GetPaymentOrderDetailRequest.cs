using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取现金流的记录
    /// yun.payment.order.detail.get
    /// </summary>
    public class GetPaymentOrderDetailRequest : ITopRequest<GetPaymentOrderDetailResponse>
    {
        /// <summary>
        /// 现金流记录ID
        /// </summary>
        public long Id { get; set; }

        public string GetApiName()
        {
            return "yun.payment.order.detail.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
