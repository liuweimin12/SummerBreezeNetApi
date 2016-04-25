using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 获取单条文章留言
    /// chenggou.archive.question.get
    /// </summary>
    public class GetArchiveQuestionRequest : ITopRequest<GetArchiveQuestionResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.question.get";
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
