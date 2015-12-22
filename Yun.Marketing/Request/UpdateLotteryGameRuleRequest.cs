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
     /// 更新抽奖游戏规则
     /// chenggou.game.lottery.update
     /// </summary>
    public class UpdateLotteryGameRuleRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 抽奖规则ID
        /// </summary>
        public int LotteryId { get; set; }

        /// <summary>
        /// 最多中奖次数
        /// </summary>
        public int MaxAward { get; set; }


        /// <summary>
        /// 最多游戏次数
        /// </summary>
        public int MaxPlayTimes { get; set; }

        /// <summary>
        /// 每天最多抽奖次数
        /// </summary>
        public int MaxTimesPerDay { get; set; }


        /// <summary>
        /// 扩展信息
        /// </summary>
        public string Ext { get; set; }


        /// <summary>
        /// 奖品，JSON字符串
        /// </summary>
        public List<EditPrizeJson> PrizeContent { get; set; }



        public string GetApiName()
        {
            return "chenggou.game.lottery.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"lotteryid", LotteryId},
                {"maxaward", MaxAward},
                {"maxplaytimes", MaxPlayTimes},
                {"maxtimesperday", MaxTimesPerDay},
                {"ext", Ext},
                {"prizecontent", PrizeContent}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("lotteryid", LotteryId);
            RequestValidator.ValidateRequired("prizecontent", PrizeContent);
        }
    }
}
