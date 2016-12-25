using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取游戏列表
    /// chenggou.game.list.get
    /// </summary>
    public class FindGamesRequest : ITopRequest<FindGamesResponse>
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
        /// 游戏开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 游戏结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"starttime",StartTime },
                {"endtime",EndTime }
            };

            return parameters;
        }

        public void Validate()
        {

        }
    }
}
