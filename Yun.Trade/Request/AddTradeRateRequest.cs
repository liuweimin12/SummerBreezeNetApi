using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class AddTradeRateRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 评价结果
        /// </summary>
        public string RateResult { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 动态评分Json格式
        /// </summary>
        public DynamicRatingJson RatingJson { get; set; }

        public string GetApiName()
        {
            return "chenggou.traderate.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid", OrderId},
                {"rateresult", RateResult},
                {"content", Content},
                {"ratingjson", RatingJson}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderid", OrderId);
            RequestValidator.ValidateRequired("rateresult", RateResult);
        }
    }
}
