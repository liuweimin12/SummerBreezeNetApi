using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取支付账号的ID
    /// yun.pay.payaccount.id.get
    /// </summary>
    public class GetPayAccountIdRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 类型，SHOP,COMPANY,USER
        /// </summary>
        public string ContentType { get; set; }


        public string GetApiName()
        {
            return "yun.pay.payaccount.id.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content", Content},
                {"contenttype", ContentType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
            RequestValidator.ValidateRequired("contenttype", ContentType);
        }
    }
}
