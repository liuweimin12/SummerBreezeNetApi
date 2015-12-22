using System.Collections.Generic;
using Yun.Interface;
using Yun.Marketing.Response;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 获取用户的游戏记录
    /// chenggou.game.userrecords.find
    /// </summary>
    public class FindPlayGameRecordsRequest : ITopRequest<FindPlayGameRecordsResponse>
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


        public string GetApiName()
        {
            return "chenggou.game.userrecords.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"gameid", GameId}
            };

            return parameters;
        }

        public void Validate()
        {

        }
    }
}
