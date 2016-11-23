using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_device_initialization_response")]
    public class GetDeviceInitializationResponse: YunResponse
    {
        /// <summary>
        /// 用户设备
        /// </summary>
        [XmlArray("user_devices")]
        [XmlArrayItem("user_device")]
        public List<UserDevice> UserDevices { get; set; }
    }
}
