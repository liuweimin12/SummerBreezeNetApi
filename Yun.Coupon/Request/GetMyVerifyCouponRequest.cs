using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 获取我核销的电子券
    /// </summary>
    public class GetMyVerifyCouponRequest : ITopRequest<GetCouponsResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set
            {
                _pageNum = value < 1 ? 1 : value;
            }
        }

        private int _pageNum = 1;

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value < 1 ? 1 : value;
            }
        }

        private int _pageSize = 1;


        /// <summary>
        /// 码ID
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string ItemCode { get; set; }


        /// <summary>
        /// 订单号
        /// </summary>
        public int TradeId { get; set; }


        /// <summary>
        /// 待查询的核销时间开始
        /// </summary>
        public DateTime? ConsumeTimeStart { get; set; }

        /// <summary>
        /// 待查询的核销时间结束
        /// </summary>
        public DateTime? ConsumeTimeEnd { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public string Sort { get; set; }


        public string GetApiName()
        {
            return "chenggou.coupons.myverify.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"couponid",CouponId},
                {"itemtitle",ItemTitle},
                {"itemcode",ItemCode},
                {"tradeid",TradeId},
                {"consumetimestart",ConsumeTimeStart},
                {"consumetimeend",ConsumeTimeEnd},
                {"sort",Sort}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
