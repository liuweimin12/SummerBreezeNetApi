using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取网站设置信息
    /// chenggou.site.config.get
    /// </summary>
    public class GetWebSettingRequest : ITopRequest<GetWebSettingResponse>
    {

        public string GetApiName()
        {
            return "chenggou.site.config.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {

            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
