using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    public class GeneratePayHtmlRequest : ITopRequest<GeneratePayHtmlResponse>
    {
        /// <summary>
        /// 支付流水ID 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNum { get; set; }

        /// <summary>
        /// POST|GET
        /// </summary>
        public string HtmlMethod { get; set; }

        /// <summary>
        /// 返回地址
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 跳转的商家地址
        /// </summary>
        public string MerchantUrl { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.onlinepay.paymenthtml.generate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"outtradenum", OutTradeNum},
                {"htmlmethod", HtmlMethod},
                {"returnurl",ReturnUrl},
                {"merchanturl",MerchantUrl},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("htmlmethod", HtmlMethod);
        }
    }
}
