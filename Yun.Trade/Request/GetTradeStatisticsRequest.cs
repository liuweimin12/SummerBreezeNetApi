using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取交易统计数据报表
    /// chenggou.trade.statistics.list.get
    /// </summary>
    public class GetTradeStatisticsRequest : ITopRequest<GetDailyTradeStatisticsResponse>
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
        /// 商品全局类目ID
        /// </summary>
        public int ItemCatId { get; set; }


        /// <summary>
        /// 时间段开始
        /// </summary>
        public DateTime? MinDateTime { get; set; }


        /// <summary>
        /// 时间段结束时间
        /// </summary>
        public DateTime? MaxDateTime { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.statistics.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"shopid",ShopId},
                {"companyid",CompanyId},
                {"itemcatid",ItemCatId},
                {"mindatetime",MinDateTime},
                {"maxdatetime",MaxDateTime}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("mindatetime", MinDateTime);
            RequestValidator.ValidateRequired("maxdatetime", MaxDateTime);
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 1100);
        }
    }
}
