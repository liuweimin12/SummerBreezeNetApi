using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Sms.Request
{
    public class SetSignatureRequest : ITopRequest<BoolResultResponse>
    {
        public string Signature { get; set; }

        public bool Enabled { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.signature.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary
            {
                {"signature",Signature},
                {"enabled",Enabled}
            };
        }

        public void Validate()
        {

        }
    }
}
