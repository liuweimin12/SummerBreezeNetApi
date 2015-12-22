using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    public class GetTradeDeductionRequest : ITopRequest<GetTradeStringResponse>
    {
        /// <summary>
        /// 公司id
        /// </summary>
        public int? CompanyId { get; set; }


        public string GetApiName()
        {
            return "chenggou.tradededuction.get";
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

        }
    }
}
