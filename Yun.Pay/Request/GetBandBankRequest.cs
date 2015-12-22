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
    /// 获取银行卡详情
    /// chenggou.pay.userbankcard.get
    /// </summary>
    public class GetBandBankRequest : ITopRequest<GetBandBankResponse>
    {
        public int Id { get; set; }
        public string GetApiName()
        {
            return "chenggou.pay.userbankcard.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
