using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    public class GetAddressRequest : ITopRequest<GetAddressResponse>
    {
        public string GetApiName()
        {
            return "chenggou.user.address.get";
        }
        public int Id { get; set; }

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
        }
    }
}
