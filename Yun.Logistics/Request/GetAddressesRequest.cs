using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取用户的收货地址列表
    /// 需要授权
    /// 获取当前用户名下的收货地址列表
    /// </summary>
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
