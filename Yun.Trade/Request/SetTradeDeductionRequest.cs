using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class SetTradeDeductionRequest : ITopRequest<BoolResultResponse>
    {
        public double Content { get; set; }

        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.tradededuction.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content", Content},
                {"companyid", CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
            RequestValidator.ValidateMinValue("content", Content, 0);
            RequestValidator.ValidateMaxValue("content", Content, 100);
        }
    }
}
