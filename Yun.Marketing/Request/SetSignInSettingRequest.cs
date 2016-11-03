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
    /// 设置签到获得记得积分规则
    /// yun.user.signin.rule.set
    /// </summary>
    public class SetSignInSettingRequest: ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 积分规则，每天可以领取的积分，中间用逗号隔开
        /// </summary>
        public string Rule { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enabled { get; set; }

        public string GetApiName()
        {
            return "yun.user.signin.rule.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"rule", Rule},
                {"enabled", Enabled}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("rule", Rule);
        }
    }
}
