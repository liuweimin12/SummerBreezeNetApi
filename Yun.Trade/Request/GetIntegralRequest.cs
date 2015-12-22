using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取当前公司的积分兑换规则
    /// chenggou.integral.traderule.get
    /// </summary>
    public class GetIntegralRequest : ITopRequest<GetIntegralResponse>
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.integral.traderule.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
           
        }
    }
}
