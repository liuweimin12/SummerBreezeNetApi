using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 生成代金券
    /// chenggou.cashcoupon.generate
    /// </summary>
    public class GenerateCashCouponRequest:ITopRequest<StringResultResponse>
    {
        /// <summary>
        /// 代金券分类ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 需要生成的数量
        /// </summary>
        public int Num { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.generate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"num", Num},
                {"categoryid", CategoryId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num", Num);
            RequestValidator.ValidateMinValue("num", Num, 1);
            RequestValidator.ValidateRequired("categoryid", CategoryId);
            RequestValidator.ValidateMinValue("categoryid", CategoryId, 1);
        }
    }
}
