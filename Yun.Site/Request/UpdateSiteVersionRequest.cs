using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 更新站点的版本号
    /// yun.site.version.update
    /// </summary>
    public class UpdateSiteVersionRequest: ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 详细内容
        /// </summary>
        public string Note { get; set; }


        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 对外的更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
         

        public string GetApiName()
        {
            return "yun.site.version.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"note",Note},
                {"type",Type},
                {"title",Title},
                {"url",Url },
                {"version",Version },
                {"updatetime",UpdateTime },
                {"id",Id } 
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateRequired("version", Version);
        }
    }
}
