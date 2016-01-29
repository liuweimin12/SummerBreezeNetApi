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
    /// 获取所有回复规则
    /// chenggou.weixin.rules.find
    /// </summary>
    public class FindRulesRequest : ITopRequest<FindRulesResponse>
    {
        /// <summary>
        /// 微信公众号ID
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }



        public string GetApiName()
        {
            return "chenggou.weixin.rules.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accountid", AccountId},
                {"status", Status}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("accountid", AccountId);
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
        }
    }
}
