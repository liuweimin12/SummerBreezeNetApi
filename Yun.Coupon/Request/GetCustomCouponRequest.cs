using System.Collections.Generic;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 获取自定义电子券信息
    /// chenggou.coupon.custom.get
    /// </summary>
    public class GetCustomCouponRequest: ITopRequest<GetCustomCouponResponse>
    {
        /// <summary>
        /// 自定义电子券ID
        /// </summary>
        public int CustomCouponId { get; set; }

        /// <summary>
        /// 自定义电子券编码
        /// </summary>
        public string CouponCode { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.custom.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"customcouponid", CustomCouponId},
                {"couponcode", CouponCode}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
