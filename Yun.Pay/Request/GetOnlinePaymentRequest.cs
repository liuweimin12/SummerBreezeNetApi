using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class GetOnlinePaymentRequest : ITopRequest<OnlinePaymentResponse>
    {
        /// <summary>
        /// 支付方式，可选字段：MOBILE，PC
        /// </summary>
        public string PayMethod { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.onlinepayment.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"paymethod",PayMethod},
                {"companyid",CompanyId }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("paymethod", PayMethod);
        }
    }
}
