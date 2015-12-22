using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class GetShopQuestionRequest : ITopRequest<QuestionResponse>   
    {
        /// <summary>
        /// 问题ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.question.get";
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
