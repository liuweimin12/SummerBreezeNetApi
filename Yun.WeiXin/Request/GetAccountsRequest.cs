using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取所有微信账号
    /// </summary>
    public class GetAccountsRequest:ITopRequest<GetAccountsResponse>
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 账号名，支持模糊查询
        /// </summary>
        public string Name { get; set; }

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

        public string GetApiName()
        {
            return "chenggou.weixin.accounts.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"shopid", ShopId},
                {"companyid",CompanyId},
                {"name",Name},
                {"pagenum",PageNum},
                {"pagesize",PageSize}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
