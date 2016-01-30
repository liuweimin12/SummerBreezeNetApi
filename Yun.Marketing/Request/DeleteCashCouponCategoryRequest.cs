using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 删除代金券类别
    /// chenggou.cashcoupon.category.delete
    /// </summary>
    public class DeleteCashCouponCategoryRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        public int CategoryId { get; set; }


        public string GetApiName()
        {
            return "chenggou.cashcoupon.category.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"categoryid",CategoryId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("categoryid", CategoryId);
            RequestValidator.ValidateMinValue("categoryid", CategoryId, 1);
        }
    }
}
