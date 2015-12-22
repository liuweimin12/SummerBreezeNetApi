using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 玩积分规则游戏
    /// chenggou.game.integralrule.play
    /// </summary>
    public class PlayIntegralGameRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.integralrule.play";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"gameid", GameId},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("gameid", GameId);
        }
    }
}
