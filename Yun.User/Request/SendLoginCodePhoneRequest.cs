using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 发送验证码
    /// 向某手机发送验证码
    /// </summary>
    public class SendLoginCodePhoneRequest : ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public string MobilePhone { get; set; }


        /// <summary>
        /// 公司ID
        /// 需要调用的公司短信通道，不填则使用平台方
        /// </summary>
        public int? CompanyId { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.phone.sendlogincode";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"mobilephone",MobilePhone},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("mobilephone", MobilePhone);
        }
    }
}
