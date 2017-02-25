using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 生成微信支付的JSAPI参数
    /// chenggou.pay.weixin.jsapipayparm
    /// </summary>
    public class GenerateJsApiPayParmRequest:ITopRequest<GenerateJsApiPayParmResponse>
    {
        /// <summary>
        /// 微信支付预订单号
        /// </summary>
        public string PrepayId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        public string PayType { get; set; }

        public string GetApiName()
        {
            return "chenggou.pay.weixin.jsapipayparm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid", CompanyId},
                {"prepayid", PrepayId},
                {"paytype",PayType }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("prepayid", PrepayId);
        }
    }
}
