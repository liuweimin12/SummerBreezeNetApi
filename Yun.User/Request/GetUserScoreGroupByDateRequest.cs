using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户的积分，按日进行分组
    /// yun.user.score.list.groupbyday.get
    /// </summary>
    public class GetUserScoreGroupByDateRequest: ITopRequest<GetUserScoreGroupByDateResponse>
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        public string GetApiName()
        {
            return "yun.user.score.list.groupbyday.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"starttime",StartTime},
                {"endtime",EndTime}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("starttime", StartTime);
            RequestValidator.ValidateRequired("endtime", EndTime);
        }
    }
}
