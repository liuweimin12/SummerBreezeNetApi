using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取抽奖规则
    /// chenggou.game.lotteryrule.get
    /// </summary>
    public class GetLotteryRuleRequest : ITopRequest<GetLotteryRuleResponse>
    {
        /// <summary>
        /// 抽奖ID
        /// </summary>
        public int LotteryId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"lotteryid", LotteryId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}