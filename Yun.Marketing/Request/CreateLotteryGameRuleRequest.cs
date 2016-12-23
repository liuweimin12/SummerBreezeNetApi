using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 创建抽奖游戏规则
    /// chenggou.game.lottery.add
    /// </summary>
    public class CreateLotteryGameRuleRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

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


        /// <summary>
        /// 游戏开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }


        /// <summary>
        /// 游戏结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }



        public string GetApiName()
        {
            return "chenggou.game.lottery.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"gameid", GameId},
                {"maxaward", MaxAward},
                {"maxplaytimes", MaxPlayTimes},
                {"maxtimesperday", MaxTimesPerDay},
                {"ext", Ext},
                {"prizecontent", PrizeContent},
                {"starttime", StartTime},
                {"endtime", EndTime},
                {"state",State }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("gameid", GameId);
            RequestValidator.ValidateRequired("prizecontent", PrizeContent);
        }
    }
}
