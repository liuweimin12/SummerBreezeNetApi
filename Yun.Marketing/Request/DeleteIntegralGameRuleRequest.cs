using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 删除积分游戏规则
    /// chenggou.game.integralrule.delete
    /// </summary>
    public class DeleteIntegralGameRuleRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 积分游戏规则
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.integralrule.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
