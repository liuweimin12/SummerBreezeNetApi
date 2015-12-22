using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 获取买家已买到的电子券
    /// 需要授权
    /// </summary>
    public class GetBuyerCouponsRequest : ITopRequest<GetCouponsResponse>
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
        /// 订单号
        /// </summary>
        public int TradeId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public string Sort { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupons.bought.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize",PageSize},
                {"tradeid",TradeId},
                {"sort",Sort}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
