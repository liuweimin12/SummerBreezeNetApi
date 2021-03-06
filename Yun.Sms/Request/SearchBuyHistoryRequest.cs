﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Sms.Response;

namespace Yun.Sms.Request
{
    public class SearchBuyHistoryRequest : ITopRequest<GetBuyHistoryResponse>
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
        public long StartTime { get; set; }

        /// <summary>
        /// 搜索结束时间
        /// </summary>
        public long EndTime { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }


        public string GetApiName()
        {
            return "chenggou.sms.buyhistory.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"starttime",StartTime},
                {"endtime",EndTime},
                {"nick",Nick}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
