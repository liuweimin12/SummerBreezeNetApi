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
    /// 获取限时折扣详情
    /// chenggou.promotionmisc.limitdiscount.activity.get
    /// 不用授权
    /// </summary>
    public class GetLimitDiscountRequest : ITopRequest<GetLimitDiscountResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int ActivityId { get; set; }

        public string GetApiName()
        {
            return "chenggou.promotionmisc.limitdiscount.activity.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"activityid",ActivityId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activityid", ActivityId);
        }
    }
}
