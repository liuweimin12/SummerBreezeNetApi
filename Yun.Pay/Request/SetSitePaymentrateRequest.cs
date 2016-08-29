using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class SetSitePaymenTrateRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 开发者ID
        /// </summary>
        public int DeveloperId { get; set; }

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
            return "chenggou.site.paymentrate.set ";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"developerid", DeveloperId},
                {"pc", Pc},
                {"mobile", Mobile},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("developerid", DeveloperId);
            RequestValidator.ValidateRequired("pc", Pc);
            RequestValidator.ValidateMinValue("pc", Pc, 0);
            RequestValidator.ValidateMaxValue("pc", Pc, 100);
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateMinValue("mobile", Mobile, 0);
            RequestValidator.ValidateMaxValue("mobile", Mobile, 100);
        }
    }
}
