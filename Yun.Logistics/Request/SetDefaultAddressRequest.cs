using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 收货地址设为默认
    /// 将某用户下的收货地址设为默认
    /// </summary>
    public class SetDefaultAddressRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 地址ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.address.default.set";
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
