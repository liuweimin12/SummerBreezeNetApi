using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class SetCompanyPaymentRateRequest : ITopRequest<BoolResultResponse>
    {
        public int CompanyId { get; set; }

        /// <summary>
        /// PC端费率
        /// </summary>
        public double Pc { get; set; }

        /// <summary>
        /// 移动端费率
        /// </summary>
        public double Mobile { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.company.paymentrate.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid", CompanyId},
                {"pc", Pc},
                {"mobile", Mobile},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("companyid", CompanyId);
            RequestValidator.ValidateRequired("pc", Pc);
            RequestValidator.ValidateMinValue("pc", Pc, 0);
            RequestValidator.ValidateMaxValue("pc", Pc, 100);
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateMinValue("mobile", Mobile, 0);
            RequestValidator.ValidateMaxValue("mobile", Mobile, 100);
        }
    }
}
