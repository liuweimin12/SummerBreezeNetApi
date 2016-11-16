using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取代金券类别
    /// chenggou.cashcoupon.categories.find
    /// </summary>
    public class FindCashCouponCategoriesRequest :ITopRequest<FindCashCouponCategoriesResponse>
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
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// 代金券类型
        /// </summary>
        public string CouponType { get; set; }

        /// <summary>
        /// 代金券类型
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 有效期
        /// 1：未开始，2：进行中，3：已结束
        /// </summary>
        public int ValidityPeriod { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// 显示位置
        /// </summary>
        public int? DisplayPosition { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.categories.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"shopid",ShopId},
                {"companyid",CompanyId},
                {"coupontype",CouponType},
                {"name",Name},
                {"validityperiod",ValidityPeriod},
                {"status",Status},
                {"displayposition",DisplayPosition }
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
