using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetQuestionRequest : ITopRequest<ItemAskResponse>
    {
        /// <summary>
        /// 商品问题ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.question.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
