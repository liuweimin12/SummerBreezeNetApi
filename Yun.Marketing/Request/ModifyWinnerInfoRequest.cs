using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 修改积分游戏规则的获奖情况
    /// chenggou.game.integralrule.winner.modify
    /// </summary>
    public class ModifyWinnerInfoRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 获奖人ID
        /// </summary>
        public int WinnerId { get; set; }

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
            return "chenggou.game.integralrule.winner.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"winnerid", WinnerId},
                {"awardinfo", AwardInfo},
                {"ext", Ext},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("winnerid", WinnerId);
            RequestValidator.ValidateRequired("awardinfo", AwardInfo);
        }
    }
}
