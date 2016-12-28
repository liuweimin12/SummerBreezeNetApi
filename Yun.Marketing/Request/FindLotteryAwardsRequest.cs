using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取抽奖规则中的领奖信息
    /// chenggou.game.lotteryrule.awards.find
    /// </summary>
    public class FindLotteryAwardsRequest : ITopRequest<FindLotteryAwardsResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

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
        /// 抽奖ID
        /// </summary>
        public int LotteryId { get; set; }


        /// <summary>
        /// 奖品ID
        /// </summary>
        public int PrizeId { get; set; }

        /// <summary>
        /// 状态,0：未抽奖，1：已抽奖，2：已领奖
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 是否中奖
        /// </summary>
        public bool? IsWinning { get; set; }


        public string GetApiName()
        {
            return "chenggou.game.lotteryrule.awards.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"lotteryid", LotteryId},
                {"prizeid", PrizeId},
                {"status", Status},
                {"gameid", GameId},
                {"userid", UserId},
                {"iswinning", IsWinning},
            };

            return parameters;
        }

        public void Validate()
        {
        }
    }
}
