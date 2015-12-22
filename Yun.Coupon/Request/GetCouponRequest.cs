using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Coupon.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 获取电子券的详细信息
    /// </summary>
    public class GetCouponRequest : ITopRequest<GetCouponResponse>
    {
        /// <summary>
        /// 电子券编号
        /// </summary>
        public string CouponId { get; set; }
        public string GetApiName()
        {
            return "chenggou.coupon.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"couponid",CouponId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("couponid", CouponId);
        }
    }
}
