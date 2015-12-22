using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Response;

namespace Yun.Logistics.Request
{
    public class GetDefaultAddressRequest : ITopRequest<GetDefaultAddressResponse>
    {
        public string GetApiName()
        {
            return "chenggou.user.address.default.get";
        }

        /// <summary>
        /// 地址类型，默认为0
        /// </summary>
        public int AddressType { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"addresstype", AddressType}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
