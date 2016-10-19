using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取充值卡分类的列表
    /// chenggou.prepaidcard.category.list.get
    /// </summary>
    public class GetPrepaidCardTypeListRequest : ITopRequest<GetPrepaidCardTypeListResponse>
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
        /// 需要查询某店铺下的所有充值卡
        /// </summary>
        public int? ShopId { get; set; }


        /// <summary>
        /// 需要查询某公司下的所有充值卡
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.category.list.get";
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
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 100);
        }
    }
}
