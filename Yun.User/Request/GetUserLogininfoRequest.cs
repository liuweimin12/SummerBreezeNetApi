using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 获取用户的登录信息
    /// yun.user.logininfo.list.get
    /// </summary>
    public class GetUserLogininfoRequest : ITopRequest<GetUserLoginInfoResponse>
    {
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


        public string GetApiName()
        {
            return "yun.user.logininfo.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"userid", UserId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("userid", UserId);
            RequestValidator.ValidateMinValue("userid", UserId, 1);
        }
    }
}
