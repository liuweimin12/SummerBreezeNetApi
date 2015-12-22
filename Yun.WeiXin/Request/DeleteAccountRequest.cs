using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 删除微信账号
    /// </summary>
    public class DeleteAccountRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 微信账号ID
        /// </summary>
        public int AccountId { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.account.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accountid", AccountId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
        }
    }
}
