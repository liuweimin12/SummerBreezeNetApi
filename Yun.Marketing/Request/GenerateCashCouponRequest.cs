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
        /// 需要生成的数量
        /// </summary>
        public int Num { get; set; }

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
        /// 代金券名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 代金券类型
        /// </summary>
        public string CouponType { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.generate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"num", Num},
                {"credit", Credit},
                {"begintime", BeginTime},
                {"endtime", EndTime},
                {"range", Range},
                {"itemdsid", ItemdsId},
                {"minprice", MinPrice},
                {"name", Name},
                {"coupontype",CouponType }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num", Num);
            RequestValidator.ValidateMinValue("num", Num, 1);
            RequestValidator.ValidateRequired("credit", Credit);
            RequestValidator.ValidateMinValue("credit", Credit, 0.01);
        }
    }
}
