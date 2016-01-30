using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 解除代金券的绑定
    /// chenggou.cashcoupon.removebinding
    /// </summary>
    public class RemoveBindingCashCouponRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 代金券ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.removebinding";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
