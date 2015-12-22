using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取抽奖规则中的领奖信息
    /// chenggou.game.lotteryrule.award.get
    /// </summary>
    public class GetLotteryAwardRequest : ITopRequest<GetLotteryAwardResponse>
    {
        /// <summary>
        /// 抽奖规则的领奖ID
        /// </summary>
        public int LotteryAwardId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.award.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"lotteryawardid", LotteryAwardId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("lotteryawardid", LotteryAwardId);
        }
    }
}
