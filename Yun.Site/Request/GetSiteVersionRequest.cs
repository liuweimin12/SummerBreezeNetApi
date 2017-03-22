using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取版本号详情
    /// yun.site.version.get
    /// </summary>
    public class GetSiteVersionRequest : ITopRequest<GetSiteVersionResponse>
    {

        /// <summary>
        /// 版本号ID
        /// </summary>
        public int VersionId { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("versionid", VersionId);
            RequestValidator.ValidateMinValue("versionid", VersionId, 1);
        }

        public string GetApiName()
        {
            return "yun.site.version.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"versionid",VersionId}
            };
            return parameters;
        }

    }
}
