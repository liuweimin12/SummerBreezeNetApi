using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class GetShopQuestionsRequest : ITopRequest<QuestionsResponse>   
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 需要搜索的留言内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 回复状态-1，全部，0未回复，1已回复
        /// </summary>
        public int ReplyStatus { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.questions.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"content",Content},
                {"replystatus",ReplyStatus}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pagenum", PageNum);
            RequestValidator.ValidateRequired("pagesize", PageSize);
        }
    }
}
