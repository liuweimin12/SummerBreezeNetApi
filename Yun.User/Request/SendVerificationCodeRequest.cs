using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class SendVerificationCodeRequest : ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 用户匿名标识
        /// </summary>
        public string UserFlag { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 发送类型
        /// "EMAIL", "SMS"二选一
        /// </summary>
        public string SendType { get; set; }

        /// <summary>
        /// 目标对象，Email或者手机号
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// 动作名字,最多10个字符
        /// </summary>
        public string ActionName { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.verificationcode.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"userflag",UserFlag},
                {"companyid",CompanyId},
                {"sendtype",SendType},
                {"target",Target},
                {"actionname",ActionName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("actionname", ActionName, 20);
        }
    }
}
