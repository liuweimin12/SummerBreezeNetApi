
using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取版本号列表
    /// yun.site.version.list.find
    /// </summary>
    public class FindSiteVersionsRequest: ITopRequest<FindSiteVersionsResponse>
    {
        /// <summary>
        /// 类型
        /// </summary>
        public int? Type { get; set; }

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
            return "yun.site.version.list.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"type",Type},
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
