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
    /// 修改团购活动
    /// chenggou.promotionmisc.groupbuy.activity.update
    /// </summary>
    public class UpdateGroupBuyRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 开始时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 活动详情
        /// </summary>
        public string Detail { get; set; }


        public string GetApiName()
        {
            return "chenggou.promotionmisc.groupbuy.activity.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"activityid",ActivityId},
                {"name",Name},
                {"starttime",StartTime},
                {"endtime",EndTime},
                {"description",Description},
                {"detail",Detail}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activityid", ActivityId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("starttime", StartTime);
            RequestValidator.ValidateRequired("endtime", EndTime);
        }
    }
}
