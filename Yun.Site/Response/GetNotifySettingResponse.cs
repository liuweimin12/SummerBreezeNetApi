using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_notify_setting_response")]
    public class GetNotifySettingResponse : YunResponse
    {
        [XmlArray("notify_settings")]
        [XmlArrayItem("notify_setting")]
        public List<NotifySetting> NotifySettings { get; set; }
    }
}
