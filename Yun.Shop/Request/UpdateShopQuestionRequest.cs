using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class UpdateShopQuestionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 留言的id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        public string Content { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.question.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"content",Content}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("content", Content);
            RequestValidator.ValidateMaxLength("content", this.Content, 2000);
        }
    }
}
