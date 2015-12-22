using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class AskShopQuestionRequest: ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

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
            return "chenggou.shop.question.ask";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"content",Content},
                {"other",Other}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shopid", ShopId);
            RequestValidator.ValidateRequired("content", Content);
            RequestValidator.ValidateMaxLength("content", this.Content, 2000);
            RequestValidator.ValidateMaxLength("other", this.Other, 2000);
        }
    }
}
