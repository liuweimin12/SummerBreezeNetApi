using System.Collections.Generic;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    public class GetCouponTemplatesRequest : ITopRequest<CouponTemplateResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.templates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid",ShopId }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
