using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 根据设备号获取用户最近一次的登录token
    /// yun.user.least.token.get
    /// </summary>
    public class GetUserLeastTokenRequest : ITopRequest<GetUserLeastTokenResponse>
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceId { get; set; }


        public string GetApiName()
        {
            return "yun.user.least.token.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"deviceid", DeviceId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("deviceid", DeviceId);
        }
    }
}
