using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 设置系统通知信息
    /// yun.setting.notification.save
    /// </summary>
    public class SaveNotifySettingRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 通知设置
        /// </summary>
        public List<NotifySettingJson> NotifySetting { get; set; }

        public string GetApiName()
        {
            return "yun.setting.notification.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"notifysetting",NotifySetting}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
