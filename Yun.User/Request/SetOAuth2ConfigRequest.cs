using System.Collections.Generic;
using System.Linq;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class SetOAuth2ConfigRequest : ITopRequest<BoolResultResponse>
    {

        /// <summary>
        /// 设置字符串,格式：name:key,secret,callbak^name:key,secret,callbak
        /// </summary>
        public IList<OAth2SettingJson> Setting { get; set; }

        public string GetApiName()
        {
            return "chenggou.oauth2.config.set";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"setting", Setting}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("setting", Setting);
        }
    }
}
