using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 玩抽奖游戏后的领奖信息保存
    /// chenggou.game.lotteryrule.award
    /// </summary>
    public class AwardLotteryGameRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 抽奖的领奖ID
        /// </summary>
        public int LotteryAwardId { get; set; }

        /// <summary>
        /// 领奖信息
        /// </summary>
        public string AwardInfo { get; set; }


        /// <summary>
        /// 扩展信息
        /// </summary>
        public string Ext { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.award";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"lotteryawardid", LotteryAwardId},
                {"awardinfo", AwardInfo},
                {"ext", Ext}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("lotteryawardid", LotteryAwardId);
        }
    }
}
