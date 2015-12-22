using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    public class GetMultipleInfoSiteElementRequest : ITopRequest<MultipleInfoResponse>
    {
        /// <summary>
        /// ID值
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.site.element.getmultipleinfo";
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
