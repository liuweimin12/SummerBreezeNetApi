using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Archive.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class GetReaderArchivesRequest : ITopRequest<ArticlesResponse>
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

        public string Sort { get; set; }

        public string Title { get; set; }

        public long StartPostTime { get; set; }

        public long EndPostTime { get; set; }

        public string Fields { get; set; }

        public string ReaderName { get; set; }

        /// <summary>
        /// 文档类型，自定义
        /// </summary>
        public int Type { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.reader.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"sort",Sort},
                {"title",Title},
                {"startposttime",StartPostTime},
                {"endposttime",EndPostTime},
                {"fields",Fields},
                {"type",Type}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 40);
        }
    }
}
