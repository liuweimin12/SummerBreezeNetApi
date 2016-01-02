using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class SendLoginCodePhoneRequest : ITopRequest<StringResultResponse>
    {
        /// 目标对象，Email或者手机号
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


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
