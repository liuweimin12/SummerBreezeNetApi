using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 设置汇率
    /// yun.pay.exchangerate.set
    /// </summary>
    public class SetExchangeRateRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 1充值卡等于多少标准货币
        /// </summary>
        public double PrepaidCardRate { get; set; }

        /// <summary>
        /// 1线下支付金额等于多少标准货币
        /// </summary>
        public double CashRate { get; set; }

        public string GetApiName()
        {
            return "yun.pay.exchangerate.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardrate",PrepaidCardRate},
                {"cashrate",CashRate}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
