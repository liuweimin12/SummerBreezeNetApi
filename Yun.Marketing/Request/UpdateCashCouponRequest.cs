using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 更新代金券
    /// chenggou.cashcoupon.update
    /// </summary>
    public class UpdateCashCouponRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 面值
        /// </summary>
        public double Credit { get; set; }


        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// 范围，0：无限制，1：商品
        /// </summary>
        public int Range { get; set; }


        /// <summary>
        /// 可使用的商品ID
        /// </summary>
        public string ItemdsId { get; set; }


        /// <summary>
        /// 代金券适用范围，最低价格要求
        /// </summary>
        public double MinPrice { get; set; }

        /// <summary>
        /// 代金券ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 代金券编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 代金券名字
        /// </summary>
        public string Name { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"code", Code},
                {"id", Id},
                {"credit", Credit},
                {"begintime", BeginTime},
                {"endtime", EndTime},
                {"range", Range},
                {"itemdsid", ItemdsId},
                {"minprice", MinPrice},
                {"name",Name }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("code", Code);
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("credit", Credit);
            RequestValidator.ValidateMinValue("credit", Credit, 0.01);
        }
    }
}
