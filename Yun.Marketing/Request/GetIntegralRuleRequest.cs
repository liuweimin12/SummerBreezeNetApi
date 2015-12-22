using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取单条的游戏积分规则
    /// chenggou.game.integralrule.get
    /// </summary>
    public class GetIntegralRuleRequest:ITopRequest<GetIntegralRuleResponse>
    {
        /// <summary>
        /// 具体的规则ID
        /// </summary>
        public int RuleId { get; set; }


        public string GetApiName()
        {
            return "chenggou.game.integralrule.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ruleid", RuleId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ruleid", RuleId);
        }
    }
}
