using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 电子券延期
    /// chenggou.coupon.delay
    /// </summary>
    public class DelayCouponRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int TradeId { get; set; }


        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }


        /// <summary>
        /// 券编号
        /// </summary>
        public string CouponId { get; set; }


        /// <summary>
        /// 需要延期的天数
        /// </summary>
        public int Day { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.delay";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"tradeid",TradeId},
                {"itemid",ItemId},
                {"couponid",CouponId},
                {"day",Day}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("day", Day);
            RequestValidator.ValidateMinValue("day", Day, 1);
            RequestValidator.ValidateMaxValue("day", Day, 365);
        }
    }
}
