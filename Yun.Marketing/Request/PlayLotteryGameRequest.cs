using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 玩抽奖游戏
    /// chenggou.game.lotteryrule.play
    /// </summary>
    public class PlayLotteryGameRequest:ITopRequest<GetLotteryAwardResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.play";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"gameid", GameId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("gameid", GameId);
        }
    }
}
