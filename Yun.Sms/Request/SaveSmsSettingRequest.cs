using System.Collections.Generic;
using System.Linq;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    public class SaveSmsSettingRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 设置信息的字符串
        /// id,验证信息中的分隔符号用^,是否选择#
        /// </summary>
        public IList<SetSmsSetting> Setting { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.setting.save";
        }

        private string ConvertSetting()
        {
            var setting = "";
            if (Setting != null && Setting.Any())
            {
                setting = Setting.Aggregate(setting, (current, s) => current + (string.Format("{0},{1},{2}", s.ServiceId, s.Auth.Replace(',','^'), s.IsSelect) + "#"));
                return setting.Trim('#');
            }

            return "";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"setting", ConvertSetting() }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("setting", Setting);
        }

    }
}
