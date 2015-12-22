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
    /// 重新发送电子券号
    /// </summary>
    public class ResendCouponRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 电子券号，不同的用英文逗号分隔
        /// </summary>
        public string Coupons { get; set; }

        /// <summary>
        /// 待发送的手机号，如果为空，则按照原来的
        /// </summary>
        public string Mobile { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.resend";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"coupons",Coupons},
                {"mobile",Mobile}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("coupons", Coupons);
        }
    }
}
