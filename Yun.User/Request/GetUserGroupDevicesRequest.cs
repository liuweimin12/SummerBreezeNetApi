using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 根据用户获取设备相关信息
    /// yun.user.device.initialization.info.get
    /// </summary>
    public class GetUserGroupDevicesRequest: ITopRequest<GetUserGroupDevicesResponse>
    {
        /// <summary>
        /// 用户ID，多个用户ID用英文逗号分隔
        /// </summary>
        public string UserIds { get; set; }

        public string GetApiName()
        {
            return "yun.user.device.initialization.info.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userids", UserIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("userids", UserIds);
        }
    }
}
