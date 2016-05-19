using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 对商品进行留言
    /// </summary>
    public class AskItemQuestionRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 详细信息
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        public string Other { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.question.ask";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"content", Content},
                {"other",Other}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
            RequestValidator.ValidateRequired("content", Content);
            RequestValidator.ValidateMaxLength("content", this.Content,200);
        }
    }
}
