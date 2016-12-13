using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户最近一次的开票记录
    /// yun.user.lastinvoice.get
    /// </summary>
    public class GetLastTimeInvoiceRequest : ITopRequest<GetLastTimeInvoiceResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        public string GetApiName()
        {
            return "yun.user.lastinvoice.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("shopid", ShopId, 1);
        }
    }
}
