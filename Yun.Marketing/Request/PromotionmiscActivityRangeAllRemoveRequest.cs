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
    /// 清空活动参与的商品
    /// chenggou.promotionmisc.activity.range.all.remove
    /// </summary>
    public class PromotionmiscActivityRangeAllRemoveRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int ActivityId { get; set; }

        public string GetApiName()
        {
            return "chenggou.promotionmisc.activity.range.all.remove";
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
