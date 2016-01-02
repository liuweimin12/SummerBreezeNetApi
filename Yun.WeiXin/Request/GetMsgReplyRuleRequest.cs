using System.Collections.Generic;
using Yun.Interface;
using Yun.Util;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取消息回复规则
    /// chenggou.weixin.msgreplyrule.get
    /// </summary>
    public class GetMsgReplyRuleRequest : ITopRequest<GetDefaultReplyRuleResponse>
    {
        /// <summary>
        /// 微信公众号ID
        /// </summary>
        public int AccountId { get; set; }


        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgType { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.msgreplyrule.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
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
