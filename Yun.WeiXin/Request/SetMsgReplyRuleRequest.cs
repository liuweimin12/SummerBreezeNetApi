using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 设置消息回复规则
    /// chenggou.weixin.msgreplyrule.set
    /// </summary>
    public class SetMsgReplyRuleRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 微信公众号ID
        /// </summary>
        public int AccountId { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.msgreplyrule.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ruleid", RuleId},
                {"accountid", AccountId},
                {"msgtype", MsgType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("msgtype", MsgType);
            RequestValidator.ValidateRequired("accountid", AccountId);
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
        }
    }
}
