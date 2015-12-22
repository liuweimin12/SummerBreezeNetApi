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
    /// 删除文章留言
    /// chenggou.archive.question.delete
    /// </summary>
    public class DeleteAskRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 留言ID
        /// </summary>
        public string Ids { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.question.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ids",Ids}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
        }
    }
}
