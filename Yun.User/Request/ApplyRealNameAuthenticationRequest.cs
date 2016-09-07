using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 申请实名认证请求
    /// yun.user.realnameauthentication.apply
    /// </summary>
    public class ApplyRealNameAuthenticationRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 认证名字
        /// </summary>
        public string AuthenticationName { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// 身份证正面
        /// </summary>
        public string PositiveIdentityCard { get; set; }

        /// <summary>
        /// 身份证背面
        /// </summary>
        public string BackOfIdCard { get; set; }


        /// <summary>
        /// 身份证手持
        /// </summary>
        public string IdCardHandheld { get; set; }

        public string GetApiName()
        {
            return "yun.user.realnameauthentication.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"authenticationname",AuthenticationName},
                {"idcard",IdCard},
                {"positiveidentitycard",PositiveIdentityCard},
                {"backofidcard",BackOfIdCard},
                {"idcardhandheld",IdCardHandheld}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
