using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Coupon.Request
{
    public class DeleteTemplateRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.template.delete";
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
