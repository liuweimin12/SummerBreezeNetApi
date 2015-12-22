using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Sms.Request
{
    /// <summary>
    /// 获取短信发送自定义模板
    /// chenggou.sms.sendtemplate.get
    /// </summary>
    public class GetSmsSendTemplateRequest: ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 模板ID 
        /// </summary>
        public int TemplateId { get; set; }

        /// <summary>
        /// 模板类型
        /// electronic_voucher
        /// </summary>
        public string TemplateType { get; set; }

        /// <summary>
        /// 目标ID 
        /// </summary>
        public int ObjId { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.sendtemplate.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"templateid", TemplateId},
                {"templatetype", TemplateType},
                {"objid", ObjId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
