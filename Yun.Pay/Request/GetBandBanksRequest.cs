using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取用户下所属的银行卡列表
    /// chenggou.pay.userbankcard.list.get
    /// </summary>
    public class GetBandBanksRequest : ITopRequest<GetBandBanksResponse>
    {
        public string GetApiName()
        {
            return "chenggou.pay.userbankcard.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
