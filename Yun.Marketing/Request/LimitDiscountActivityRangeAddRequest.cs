using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 添加限时折扣活动参与的商品
    /// chenggou.promotionmisc.limitdiscount.range.add
    /// </summary>
    public class LimitDiscountActivityRangeAddRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 限时折扣的商品信息
        /// </summary>
        public List<AddLimitDiscountJson> ItemsContent { get; set; }

        public string GetApiName()
        {
            return "chenggou.promotionmisc.limitdiscount.range.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"activityid",ActivityId},
                {"itemscontent",ItemsContent}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activityid", ActivityId);
            RequestValidator.ValidateRequired("itemscontent", ItemsContent);
        }
    }
}
