using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取用户的默认地址
    /// 需要授权
    /// 根据用户的登录凭证获取用户的默认地址
    /// </summary>
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
