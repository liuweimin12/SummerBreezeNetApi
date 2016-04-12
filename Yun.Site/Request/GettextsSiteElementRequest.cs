using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取纯文字信息
    /// 根据模块标识或者模块ID获取该模块下的纯文字信息
    /// </summary>
    public class GetTextsSiteElementRequest : ITopRequest<TextsResponse>
    {
        /// <summary>
        /// 模块唯一标识
        /// </summary>
        public int ModuleId { get; set; }

        /// <summary>
        /// 模块标识
        /// </summary>
        public string ModuleFlag { get; set; }

        /// <summary>
        /// 返回数量
        /// </summary>
        public int Num { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.gettexts";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"moduleid", ModuleId },
                {"num", Num },
                {"moduleflag",ModuleFlag}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("moduleid", ModuleId);
            RequestValidator.ValidateRequired("num", Num);
        }
    }
}
