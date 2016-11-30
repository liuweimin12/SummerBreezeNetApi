using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 查询用户的积分统计数据，例如XX时间到XX时间的收入支出情况
    /// </summary>
    public class GetUserTotalScoreRequest : ITopRequest<GetUserTotalScoreResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int? UserId { get; set; }


        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 需要统计的开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }


        /// <summary>
        /// 需要统计的结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.score.statistics";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"nick", Nick},
                {"starttime",StartTime},
                {"endtime",EndTime},
                {"userid",UserId }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
