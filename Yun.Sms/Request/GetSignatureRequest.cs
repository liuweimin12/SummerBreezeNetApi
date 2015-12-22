using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Sms.Response;

namespace Yun.Sms.Request
{
    public class GetSignatureRequest : ITopRequest<GetSignatureResponse>
    {
        public string GetApiName()
        {
            return "chenggou.sms.signature.get";
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
