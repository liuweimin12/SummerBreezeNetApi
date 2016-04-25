using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 在某文章下进行留言
    /// chenggou.archive.question.ask
    /// </summary>
    public class AddArchiveAskRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        public int ArchiveId { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        public string Other { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.question.ask";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"archiveid",ArchiveId},
                {"content",Content},
                {"other",Other}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("archiveid", ArchiveId);
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
