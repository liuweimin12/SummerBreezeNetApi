using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class GetAlumbsRequest : ITopRequest<GetAlbumResponse>
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
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 物件ID
        /// </summary>
        public int ObjectId { get; set; }

        /// <summary>
        /// 是否需要过滤显示的内容
        /// </summary>
        public bool? Display { get; set; }



        public string GetApiName()
        {
            return "chenggou.user.alumbs.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"type",Type},
                {"objectid",ObjectId},
                {"display",Display}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
