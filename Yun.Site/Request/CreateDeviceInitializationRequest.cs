using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 创建设备的初始化信息
    /// yun.device.initialization.info.create
    /// </summary>
    public class CreateDeviceInitializationRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 外部的Token数据
        /// </summary>
        public IList<OuterAccount> OuterData { get; set; }

        public string GetApiName()
        {
            return "yun.device.initialization.info.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"deviceid", DeviceId},
                {"outerdata", OuterData},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("deviceid", DeviceId);
        }
    }
}
