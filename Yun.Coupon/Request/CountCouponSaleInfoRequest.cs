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
    /// 统计某商品的电子券销售情况
    /// chenggou.coupon.saleinfo.count
    /// </summary>
    public class CountCouponSaleInfoRequest : ITopRequest<CountCouponSaleInfoResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.saleinfo.count";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid",ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
            RequestValidator.ValidateMinValue("itemid", ItemId, 1);
        }
    }
}
