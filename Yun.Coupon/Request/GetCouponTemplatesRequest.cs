using System.Collections.Generic;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    public class GetCouponTemplatesRequest : ITopRequest<CouponTemplateResponse>
    {
        public string GetApiName()
        {
            return "chenggou.coupon.templates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new Dictionary<string, string>();
        }

        public void Validate()
        {
        }
    }
}
