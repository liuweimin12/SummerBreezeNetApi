using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class DeleteSiteElementRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public int Id { get; set; }


        public string GetApiName()
        {
            return "chenggou.site.element.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
