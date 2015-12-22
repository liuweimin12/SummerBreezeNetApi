using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class FindCompaniesRequest : ITopRequest<CompaniesResponse>
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

        public string Fields { get; set; }

        public string GetApiName()
        {
            return "chenggou.companies.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"fields", Fields},
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"name",Name}
            };
            return parameters;
        }

        public string Name { get; set; }

        public void Validate()
        {
        }
    }
}
