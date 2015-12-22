using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 查询电子券的销售情况
    /// chenggou.coupon.saleinfo.find
    /// </summary>
    public class FindCouponSaleInfoRequest : ITopRequest<FindCouponSaleInfoResponse>
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

        private int _pageSize = 40;


        /// <summary>
        /// 店铺ID 
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.coupon.saleinfo.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"shopid",ShopId},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
           
        }
    }
}
