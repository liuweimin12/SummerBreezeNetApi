using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Sms.Response;

namespace Yun.Sms.Request
{
    public class GetSendHistoryRequest : ITopRequest<GetSendHistoryResponse>
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
        /// 搜索开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 搜索结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }


        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.sendhistory.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"starttime", StartTime},
                {"endtime", EndTime},
                {"companyid", CompanyId},
                {"mobile", Mobile}
            };
            return parameters;
        }

        public void Validate()
        {
           
        }
    }
}
