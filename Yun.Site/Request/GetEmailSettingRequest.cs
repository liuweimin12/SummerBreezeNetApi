using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取已设置的邮件发送配置信息
    /// </summary>
    public class GetEmailSettingRequest : ITopRequest<GetEmailSettingResponse>
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.email.setting.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
