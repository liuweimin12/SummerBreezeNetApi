using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetQuestionsRequest : ITopRequest<ItemQuestionsResponse>
    {
        /// <summary>
        /// 店铺Id
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

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
            return "chenggou.item.questions.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"content",Content},
                {"replystatus",ReplyStatus},
                {"shopid",ShopId}
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
