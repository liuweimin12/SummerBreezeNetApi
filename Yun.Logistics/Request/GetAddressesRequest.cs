using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Response;

namespace Yun.Logistics.Request
{
    public class GetAddressesRequest : ITopRequest<GetAddressesResponse>
    {
        /// <summary>
        /// 排序方法，支持default,id,iddesc
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 地址类型，默认为0
        /// </summary>
        public int AddressType { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.addresses.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"addresstype", AddressType},
                {"sort", Sort}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
