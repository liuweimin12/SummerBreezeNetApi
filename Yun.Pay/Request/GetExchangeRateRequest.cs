using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取汇率的比值
    /// yun.pay.exchangerate.get
    /// </summary>
    public class GetExchangeRateRequest : ITopRequest<GetExchangeRateResponse>
    {
        public string GetApiName()
        {
            return "yun.pay.exchangerate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary();
        }

        public void Validate()
        {
        }
    }
}
