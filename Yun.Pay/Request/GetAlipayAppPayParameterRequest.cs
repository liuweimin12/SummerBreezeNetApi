using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取支付宝APP支付的参数信息
    /// yun.pay.alipay.payparameter.get
    /// </summary>
    public class GetAlipayAppPayParameterRequest : ITopRequest<GetAlipayAppPayParameterResponse>
    {
        /// <summary>
        /// 支付流水ID 
        /// </summary>
        public long? Id { get; set; }


        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNum { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "yun.pay.alipay.payparameter.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"outtradenum",OutTradeNum},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("companyid", CompanyId, 0);
        }
    }
}
