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
    /// 电子券消费，必须授权
    /// </summary>
    public class ConsumeCouponRequest : ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 电子券ID
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 需要消费的数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.consume";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"couponid",CouponId},
                {"quantity",Quantity},
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
