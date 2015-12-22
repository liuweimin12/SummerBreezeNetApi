using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    public class PassedSignatureRequest : ITopRequest<BoolResultResponse>
    {
        public bool IsPassed { get; set; }

        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.signature.passed";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary
            {
                {"ispassed",IsPassed},
                {"id",Id}
            };
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
