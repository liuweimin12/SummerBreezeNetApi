using System.Collections.Generic;
using Yun.Distribution.Response;
using Yun.Interface;

namespace Yun.Distribution.Request
{
    public class GetCooperationRequest : ITopRequest<GetUsersInfoResponse>
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
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.cooperation.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"shopid",ShopId }
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
