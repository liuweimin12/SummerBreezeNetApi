using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 生成在线退款HTML信息
    /// </summary>
    public class CreateRefundLinkRequest : ITopRequest<GeneratePayHtmlResponse>
    {
        /// <summary>
        /// 批号
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// POST|GET
        /// </summary>
        public string HtmlMethod { get; set; }

        public string GetApiName()
        {
            return "chenggou.onlinepay.refundhtml.generate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"batchno",BatchNo},
                {"htmlmethod",HtmlMethod}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("batchno", BatchNo);
            RequestValidator.ValidateRequired("htmlmethod", HtmlMethod);
        }
    }
}
