using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户的积分，按日进行分组
    /// yun.user.score.list.groupbyday.get
    /// </summary>
    public class GetUserScoreGroupByDateRequest: ITopRequest<GetUserScoreGroupByDateResponse>
    {
        /// <summary>
        /// 积分类型，不能和系统自有字段冲突
        /// </summary>
        public string IntegralType { get; set; }

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
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 空为全部，0为获取，1为使用
        /// </summary>
        public int? Direction { get; set; }

        public string GetApiName()
        {
            return "yun.user.score.list.groupbyday.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"endtime",EndTime},
                {"starttime",StartTime },
                {"direction",Direction },
                {"integraltype",IntegralType }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
