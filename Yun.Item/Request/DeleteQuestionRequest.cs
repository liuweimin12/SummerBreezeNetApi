using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class DeleteQuestionRequest : ITopRequest<BoolListResponse>
    {
        /// <summary>
        /// 留言的id，多个ID用英文逗号分割
        /// </summary>
        public string Ids { get; set; }

       
        public string GetApiName()
        {
            return "chenggou.item.question.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"ids", Ids}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
        }
    }
}
