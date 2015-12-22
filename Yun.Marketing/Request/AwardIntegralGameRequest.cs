using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 玩积分游戏后的领奖信息保存
    /// chenggou.game.integralrule.award
    /// </summary>
    public class AwardIntegralGameRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// 获得的积分数
        /// </summary>
        public int Integral { get; set; }

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
            return "chenggou.game.integralrule.award";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"gameid", GameId},
                {"integral", Integral},
                {"awardinfo", AwardInfo},
                {"ext", Ext}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("gameid", GameId);
            RequestValidator.ValidateRequired("integral", Integral);
        }
    }
}
