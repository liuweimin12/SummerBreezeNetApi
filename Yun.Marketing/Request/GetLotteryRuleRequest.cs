using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取抽奖规则
    /// chenggou.game.lotteryrule.get
    /// </summary>
    public class GetLotteryRuleRequest : ITopRequest<GetLotteryRuleResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

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
                {"gameid", GameId},
                {"lotteryid",LotteryId }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}