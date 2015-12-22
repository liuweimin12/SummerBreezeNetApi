using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取积分游戏规则
    /// chenggou.game.integralrule.list.get
    /// </summary>
    public class GetIntegralRuleListRequest: ITopRequest<GetIntegralRuleListResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.integralrule.list.get";
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
