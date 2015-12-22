using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 添加限时折扣活动参与的商品
    /// chenggou.promotionmisc.groupbuy.range.add
    /// </summary>
    public class GroupBuyActivityRangeAddRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 团购的商品信息
        /// </summary>
        public List<AddGroupBuyJson> ItemsContent { get; set; }


        public string GetApiName()
        {
            return "chenggou.promotionmisc.groupbuy.range.add";
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
