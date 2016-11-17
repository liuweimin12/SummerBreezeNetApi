using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 删除站点的版本号
    /// yun.site.version.delete
    /// </summary>
    public class DeleteSiteVersionRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "yun.site.version.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
