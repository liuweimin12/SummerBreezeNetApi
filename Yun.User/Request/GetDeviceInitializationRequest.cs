using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 根据设备号获取设备相关信息
    /// yun.device.initialization.info.get
    /// </summary>
    public class GetDeviceInitializationRequest : ITopRequest<GetDeviceInitializationResponse>
    {
        /// <summary>
        /// 设备ID，多个用英文逗号分隔
        /// </summary>
        public string DevicesId { get; set; }


        public string GetApiName()
        {
            return "yun.device.initialization.info.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"devicesid", DevicesId}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("devicesid", DevicesId);
        }
    }
}
