using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class GetDistributorsRequest :ITopRequest<TPagedResponse<SimpleUserInfo>>
    {
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
            return "chenggou.distribution.cooperation.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
