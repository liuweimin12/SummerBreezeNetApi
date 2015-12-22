using System.Collections.Generic;
using Yun.Coupon.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Coupon.Request
{
    public class GetCouponTemplateRequest : ITopRequest<GetTemplateResponse>
    {
        /// <summary>
        /// 模板id
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.template.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
