using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取支付订单列表
    /// yun.payment.orders.list.get
    /// </summary>
    public class GetPaymentOrdersRequest : ITopRequest<GetPaymentOrdersResponse>
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string TradeType { get; set; }


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
        /// 付款状态
        /// </summary>
        public string Status { get; set; }


        /// <summary>
        /// 商户订单号
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int? UserId { get; set; }

        public string GetApiName()
        {
            return "yun.payment.orders.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"starttime", StartTime},
                {"endtime", EndTime},
                {"tradetype", TradeType},
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"status", Status},
                {"merchantorderno", MerchantOrderNo},
                {"userid", UserId},
                {"companyid", CompanyId},
                {"shopid", ShopId},
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
