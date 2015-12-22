using System.Collections.Generic;
using Yun.Coupon.Response;
using Yun.Interface;

namespace Yun.Coupon.Request
{
    /// <summary>
    /// 查找自定义电子券
    /// chenggou.coupon.custom.find
    /// </summary>
    public class FindCustomCouponRequest:ITopRequest<FindCustomCouponResponse>
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

        public int ItemId { get; set; }


        public string GetApiName()
        {
            return "chenggou.coupon.custom.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"itemid", ItemId}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
