using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class SetDefaultPaymengRateRequest : ITopRequest<BoolResultResponse>
    {
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
            return "chenggou.pay.defaultpaymentrate.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pc", Pc},
                {"mobile", Mobile},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pc", Pc);
            RequestValidator.ValidateMinValue("pc", Pc, 0);
            RequestValidator.ValidateMaxValue("pc", Pc, 100);
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateMinValue("mobile", Mobile, 0);
            RequestValidator.ValidateMaxValue("mobile", Mobile, 100);
        }
    }
}
