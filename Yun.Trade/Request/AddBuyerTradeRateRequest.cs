﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 新增买家对卖家的评价
    /// yun.buyer.traderate.add
    /// </summary>
    public class AddBuyerTradeRateRequest : ITopRequest<BoolResultResponse>
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

        /// <summary>
        /// 图片集合，多个用英文逗号分隔
        /// </summary>
        public string Imgs { get; set; }

        public string GetApiName()
        {
            return "yun.buyer.traderate.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid", OrderId},
                {"rateresult", RateResult},
                {"content", Content},
                {"ratingjson", RatingJson},
                {"imgs",Imgs }
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
