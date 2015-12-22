using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 删除抽奖游戏规则
    /// chenggou.game.lotteryrule.delete
    /// </summary>
    public class DeleteLotteryGameRuleRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 抽奖规则ID
        /// </summary>
        public int LotteryId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.delete";
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
            RequestValidator.ValidateRequired("lotteryid", LotteryId);
        }
    }
}
