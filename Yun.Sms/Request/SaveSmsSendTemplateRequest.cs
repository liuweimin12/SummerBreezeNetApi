using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    /// <summary>
    /// 新增短信发送模板
    /// chenggou.sms.sendtemplate.save
    /// </summary>
    public class SaveSmsSendTemplateRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 模板名字
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        public string TemplateContent { get; set; }

        /// <summary>
        /// 模板类型
        /// electronic_voucher
        /// </summary>
        public string TemplateType { get; set; }

        /// <summary>
        /// 模板ID 
        /// </summary>
        public int? TemplateId { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool Disabled { get; set; }


        /// <summary>
        /// 目标ID 
        /// </summary>
        public int ObjId { get; set; }


        public string GetApiName()
        {
            return "chenggou.sms.sendtemplate.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"templateid", TemplateId},
                {"templatename", TemplateName},
                {"templatecontent", TemplateContent},
                {"templatetype", TemplateType},
                {"disabled", Disabled},
                {"objid", ObjId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("templatetype", TemplateType);
            RequestValidator.ValidateRequired("templatecontent", TemplateContent);
            RequestValidator.ValidateRequired("templatename", TemplateName);
            RequestValidator.ValidateRequired("objid", ObjId);
        }
    }
}
