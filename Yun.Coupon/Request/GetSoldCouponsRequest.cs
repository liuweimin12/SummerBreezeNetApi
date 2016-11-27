using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 获取已卖出的电子券
    /// </summary>
    public class GetSoldCouponsRequest : ITopRequest<GetCouponsResponse>
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
        /// 接收手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 核销状态
        /// </summary>
        public string ConsumeStatus { get; set; }

        /// <summary>
        /// 验证人昵称
        /// </summary>
        public string VerifyNick { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }


        public string GetApiName()
        {
            return "chenggou.coupons.sold.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagesize", PageSize},
                {"pagenum", PageNum},
                {"couponid", CouponId},
                {"itemtitle", ItemTitle},
                {"itemcode", ItemCode},
                {"tradeid", TradeId},
                {"consumetimestart", ConsumeTimeStart},
                {"consumetimeend", ConsumeTimeEnd},
                {"mobile", Mobile},
                {"consumestatus", ConsumeStatus},
                {"verifynick", VerifyNick},
                {"buyernick", BuyerNick},
                {"sort", Sort},
                {"companyid", CompanyId},
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
