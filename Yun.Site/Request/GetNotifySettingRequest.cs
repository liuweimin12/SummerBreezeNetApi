using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取通知的配置信息
    /// yun.setting.notification.get
    /// </summary>
    public class GetNotifySettingRequest : ITopRequest<GetNotifySettingResponse>
    {
        /// <summary>
        /// 公司ID，可以不输入
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "yun.setting.notification.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid", CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}