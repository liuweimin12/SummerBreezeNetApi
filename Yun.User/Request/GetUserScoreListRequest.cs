using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户的积分列表
    /// chenggou.user.score.list.get
    /// 授权不是必须
    /// </summary>
    public class GetUserScoreListRequest : ITopRequest<GetUserScoreListResponse>
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
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }


        /// <summary>
        /// 空为全部，0为获取，1为使用
        /// </summary>
        public int? Direction { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int? UserId { get; set; }


        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }


        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// 积分类型，不能和系统自有字段冲突
        /// </summary>
        public string IntegralType { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.score.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"nick", Nick},
                {"direction", Direction},
                {"shopid", ShopId},
                {"userid", UserId},
                {"starttime", StartTime},
                {"endtime", EndTime},
                {"integraltype", IntegralType}
            };

            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
