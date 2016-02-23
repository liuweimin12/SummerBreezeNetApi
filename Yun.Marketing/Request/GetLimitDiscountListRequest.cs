using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取限时折扣活动列表
    /// chenggou.promotionmisc.limitdiscount.activity.list.get
    /// 不用授权
    /// </summary>
    public class GetLimitDiscountListRequest : ITopRequest<GetLimitDiscountListResponse>
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
        /// 活动ID
        /// </summary>
        public int? ActivityId { get; set; }

        /// <summary>
        /// 状态，OVER（结束），DOING（进行中），PROPARE（未开始），ALL（全部）
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// 用户自定义的活动类型
        /// </summary>
        public string UserType { get; set; }


        /// <summary>
        /// 需要排除的用户类型,多个用英文逗号分隔
        /// </summary>
        public string ExcludeUserType { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActivityName { get; set; }


        public string GetApiName()
        {
            return "chenggou.promotionmisc.limitdiscount.activity.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"activityid", ActivityId},
                {"status", Status},
                {"starttime", StartTime},
                {"endtime", EndTime},
                {"usertype", UserType},
                {"excludeusertype", ExcludeUserType},
                {"companyid", CompanyId},
                {"shopid",ShopId},
                {"activityname",ActivityName }
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 100);
        }
    }
}
