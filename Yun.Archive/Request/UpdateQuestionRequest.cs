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
    /// 更新文章答疑
    /// chenggou.archive.question.update
    /// </summary>
    public class UpdateQuestionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.question.ask";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"content",Content}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
