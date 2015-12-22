using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 删除自定义电子券
    /// chenggou.coupon.custom.delete
    /// </summary>
    public class DeleteCustomCouponRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 自定义电子券ID
        /// </summary>
        public int CouponId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.custom.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"couponid", CouponId},
                {"itemid", ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
            RequestValidator.ValidateRequired("couponid", CouponId);
        }
    }
}
