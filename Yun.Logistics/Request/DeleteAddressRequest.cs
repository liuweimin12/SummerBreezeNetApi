using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    public class DeleteAddressRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.address.delete";
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
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
