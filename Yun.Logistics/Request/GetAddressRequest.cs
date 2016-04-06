using System.Collections.Generic;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取收货地址详情
    /// 根据地址ID获取收货地址详情
    /// </summary>
    public class GetAddressRequest : ITopRequest<GetAddressResponse>
    {
        public string GetApiName()
        {
            return "chenggou.user.address.get";
        }
        /// <summary>
        /// 地址ID
        /// </summary>
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
