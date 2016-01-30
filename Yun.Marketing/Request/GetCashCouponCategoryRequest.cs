using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取代金券类别
    /// chenggou.cashcoupon.category.get
    /// </summary>
    public class GetCashCouponCategoryRequest:ITopRequest<GetCashCouponCategoryResponse>
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        public int CategoryId { get; set; }


        public string GetApiName()
        {
            return "chenggou.cashcoupon.category.get";
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
