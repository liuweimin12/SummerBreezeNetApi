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
        /// 状态，0:未开始，1：进行中，2：已结束
        /// </summary>
        public int State { get; set; }

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
                {"state",State }
            };

            return parameters;
        }

        public void Validate()
        {

        }
    }
}
