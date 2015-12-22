using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 查找积分游戏的获奖者名单
    /// chenggou.game.integralrule.winners.list.get
    /// </summary>
    public class FindIntegralGameWinningListRequest: ITopRequest<FindIntegralGameWinningListResponse>
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
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }


        /// <summary>
        /// 规则ID
        /// </summary>
        public int RuleId { get; set; }


        public string GetApiName()
        {
            return "chenggou.game.integralrule.winners.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"gameid", GameId},
                {"ruleid", RuleId}
            };

            return parameters;
        }

        public void Validate()
        {
        }
    }
}
