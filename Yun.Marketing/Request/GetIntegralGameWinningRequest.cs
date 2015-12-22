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
    /// 获取积分游戏的领奖信息
    /// chenggou.game.integralrule.winner.get
    /// </summary>
    public class GetIntegralGameWinningRequest: ITopRequest<GetIntegralGameWinningResponse>
    {
        /// <summary>
        /// 领奖信息ID
        /// </summary>
        public int WinnerId { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.integralrule.winner.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"winnerid", WinnerId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("winnerid", WinnerId);
        }
    }
}
