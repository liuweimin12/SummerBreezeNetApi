using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取城市数据
    /// chenggou.city.list.get
    /// </summary>
    public class GetCitiesRequest : ITopRequest<GetCitiesResponse>
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
        /// 是否获取默认的城市数据，默认获取系统自带的城市数据
        /// </summary>
        public bool GetCustomCity { get; set; }

        /// <summary>
        /// 城市名字
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        public int? State { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int? ParentId { get; set; }

        public string GetApiName()
        {
            return "chenggou.city.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"getcustomcity",GetCustomCity},
                {"cityname",CityName},
                {"state",State},
                {"parentId",ParentId }
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
