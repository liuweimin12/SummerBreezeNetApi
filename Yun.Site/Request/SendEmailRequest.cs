using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 发送邮件
    /// chenggou.site.email.send
    /// </summary>
    public class SendEmailRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 目标邮件内容
        /// </summary>
        public string TargetEmail { get; set; }


        /// <summary>
        /// 邮件内容
        /// </summary>
        public string Body { get; set; }


        /// <summary>
        /// 邮件标题
        /// </summary>
        public string Subject { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.email.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"targetemail",TargetEmail},
                {"body",Body},
                {"subject",Subject},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("targetemail", TargetEmail);
            RequestValidator.ValidateRequired("body", Body);
            RequestValidator.ValidateRequired("subject", Subject);
        }
    }
}
