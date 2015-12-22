using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取游戏纲要
    /// chenggou.game.get
    /// </summary>
    public class GetGameRequest: ITopRequest<GetGameResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.get";
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
