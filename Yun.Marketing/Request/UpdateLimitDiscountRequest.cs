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
    /// 修改限时折扣活动
    /// chenggou.promotionmisc.limitdiscount.activity.update
    /// </summary>
    public class UpdateLimitDiscountRequest : ITopRequest<IntResultResponse>
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
        /// 活动范围：0表示全部参与； 1表示部分商品参与。
        /// </summary>
        private int ParticipateRange { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 用户自定义的活动类型
        /// </summary>
        public string UserType { get; set; }

        public string GetApiName()
        {
            return "chenggou.promotionmisc.limitdiscount.activity.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"activityid",ActivityId},
                {"name",Name},
                {"participaterange",ParticipateRange},
                {"starttime",StartTime},
                {"endtime",EndTime},
                {"description",Description},
                {"usertype",UserType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activityid", ActivityId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("participaterange", ParticipateRange);
            RequestValidator.ValidateRequired("starttime", StartTime);
            RequestValidator.ValidateRequired("endtime", EndTime);
        }
    }
}
