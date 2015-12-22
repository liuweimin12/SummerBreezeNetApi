using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 生成抽奖游戏中的中奖信息
    /// chenggou.game.lotteryrule.award.generate
    /// </summary>
    public class GenerateLotteryAwardRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 抽奖游戏规则的ID
        /// </summary>
        public int LotteryId { get; set; }

        /// <summary>
        /// 需要生成的总数量
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 奖品
        /// </summary>
        public List<LotteryPrizeJson> Prize { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.award.generate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"lotteryid",LotteryId},
                {"totalnum",TotalNum},
                {"prize",Prize}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("lotteryid", LotteryId);
            RequestValidator.ValidateRequired("prize", Prize);
        }
    }
}
