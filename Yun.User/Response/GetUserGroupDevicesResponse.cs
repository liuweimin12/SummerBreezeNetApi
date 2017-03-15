using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.User.Response
{
    [XmlRoot("get_user_group_devices_response")]
    public class GetUserGroupDevicesResponse
    {
        /// <summary>
        /// 用户分组设备数据
        /// </summary>
        [XmlArray("user_group_devices")]
        [XmlArrayItem("user_group_device")]
        public List<UserGroupDevices> UserGroupDevices { get; set; }
    }
}
