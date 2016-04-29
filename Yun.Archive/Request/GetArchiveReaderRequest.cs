using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 根据读者的用户名获取文章
    /// </summary>
    public class GetArchiveReaderRequest: ITopRequest<ArticlesResponse>
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
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 发送开始时间
        /// </summary>
        public long StartPostTime { get; set; }

        /// <summary>
        /// 发送结束时间
        /// </summary>
        public long EndPostTime { get; set; }

        /// <summary>
        /// 需要返回的字段
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
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
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"sort",Sort},
                {"title",Title},
                {"startposttime",StartPostTime},
                {"endposttime",EndPostTime},
                {"fields",Fields},
                {"readername",ReaderName},
                {"type",Type}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 100);
        }
    }
}
