using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 查询电子券
    /// </summary>
    public class InquiryCouponRequest : ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 电子券ID
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.inquiry";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"couponid",CouponId},
                {"ip",Ip}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("couponid", CouponId);
        }
    }
}
