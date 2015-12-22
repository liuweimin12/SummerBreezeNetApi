using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Util;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取微信账号
    /// </summary>
    public class GetAccountRequest:ITopRequest<GetAccountResponse>
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        public int AccountId { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.account.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accountid",AccountId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
        }
    }
}
