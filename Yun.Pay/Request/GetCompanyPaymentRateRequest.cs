using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class GetCompanyPaymentRateRequest : ITopRequest<GetCompanyPaymentRateResponse>
    {
        /// <summary>
        /// 公司id
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.company.paymentrate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid", CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("companyid", CompanyId);
        }
    }
}
