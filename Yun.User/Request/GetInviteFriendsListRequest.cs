using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取发送朋友邀请的记录
    /// yun.user.friend.invatehistory.list.get
    /// </summary>
    public class GetInviteFriendsListRequest : ITopRequest<GetInviteFriendsListResponse>
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
        /// 状态
        /// </summary>
        public int? State { get; set; }


        /// <summary>
        /// 商品字段
        /// </summary>
        public string Fields { get; set; }

        public string GetApiName()
        {
            return "yun.user.friend.invatehistory.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {

            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"fields",Fields },
                {"state",State }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
