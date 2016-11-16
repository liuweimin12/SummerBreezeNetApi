using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 查找已经生成的代金券
    /// chenggou.cashcoupon.find
    /// </summary>
    public class FindCashCouponRequest : ITopRequest<FindCashCouponResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set { _pageNum = value < 1 ? 1 : value; }
        }

        private int _pageNum = 1;

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value < 1 ? 1 : value; }
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
        /// 绑定的用户ID
        /// </summary>
        public int? BindUserId { get; set; }


        /// <summary>
        /// 代金券编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 代金券类型
        /// </summary>
        public string CouponType { get; set; }

        /// <summary>
        /// 代金券金额
        /// </summary>
        public double MinPrice { get; set; }


        /// <summary>
        /// 代金券分类ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 显示位置
        /// </summary>
        public int? DisplayPosition { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"shopid", ShopId},
                {"companyid", CompanyId},
                {"binduserid", BindUserId},
                {"code", Code},
                {"coupontype",CouponType },
                {"minprice", MinPrice},
                {"categoryid",CategoryId },
                {"displayposition",DisplayPosition }
            };

            return parameters;
        }

        public void Validate()
        {
        }
    }
}
