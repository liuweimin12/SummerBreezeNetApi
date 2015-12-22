using System.Collections.Generic;
using Yun.Domain;
using Yun.Interface;
using Yun.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 设置网站信息
    /// 如果为空，会删除所有信息
    /// chenggou.site.config.set
    /// </summary>
    public class SetWebSettingRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 设置参数
        /// </summary>
        public List<YunKeyValuePair<string,string>>Setting { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.config.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"setting",Setting}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
