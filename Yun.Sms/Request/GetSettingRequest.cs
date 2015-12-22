using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Sms.Response;

namespace Yun.Sms.Request
{
    public class GetSettingRequest : ITopRequest<GetSettingResponse>
    {
        public string GetApiName()
        {
            return "chenggou.sms.setting.get";
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
