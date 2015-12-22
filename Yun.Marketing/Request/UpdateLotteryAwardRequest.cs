using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 更改抽奖信息中的领奖信息
    /// chenggou.game.lotteryrule.award.modify
    /// </summary>
    public class UpdateLotteryAwardRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 所关联的奖品ID
        /// </summary>
        public int? PrizeId { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        public int? Status { get; set; }


        /// <summary>
        /// 抽奖中的领奖信息
        /// </summary>
        public int LotteryAwardId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.award.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"lotteryawardid", LotteryAwardId},
                {"prizeid", PrizeId},
                {"status", Status}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("lotteryawardid", LotteryAwardId);
        }
    }
}
