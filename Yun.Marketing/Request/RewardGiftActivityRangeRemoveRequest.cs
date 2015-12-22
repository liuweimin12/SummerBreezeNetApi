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
    /// 去除满就送活动参与的商品
    /// chenggou.promotionmisc.mjs.range.remove
    /// </summary>
    public class RewardGiftActivityRangeRemoveRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 商品ID，多个用英文逗号分隔
        /// </summary>
        public string Ids { get; set; }

        public string GetApiName()
        {
            return "chenggou.promotionmisc.mjs.range.remove";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"activityid",ActivityId},
                {"ids",Ids}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activityid", ActivityId);
            RequestValidator.ValidateRequired("ids", Ids);
        }
    }
}
