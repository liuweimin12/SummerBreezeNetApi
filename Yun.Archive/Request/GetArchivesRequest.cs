using System.Collections.Generic;
using Yun.Archive.Response;
using Yun.Interface;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 获取文章
    /// 获取文章列表
    /// 不需要授权
    /// </summary>
    public class GetArchivesRequest : ITopRequest<ArticlesResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archives.get";
        }

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
        /// 作者id
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// 排序 idasc--id升序   viewdesc--浏览量降序  sort--sort排序  timedesc --发布时间降序   time --发布时间升序
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 开始发送时间
        /// UNIX时间戳
        /// </summary>
        public long StartPostTime { get; set; }

        /// <summary>
        /// 结束发送时间
        /// UNIX时间戳
        /// </summary>
        public long EndPostTime { get; set; }

        /// <summary>
        /// 分类id
        /// </summary>
        public int TaxonomyId { get; set; }

        /// <summary>
        /// 需要返回的字段
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 文章发布状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 是否已经发布
        /// </summary>
        public bool? HasPunish { get; set; }

        /// <summary>
        /// 标签名字
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 分类名字
        /// </summary>
        public string CategoryName { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 自定义类型
        /// </summary>
        public int? CustomType { get; set; }


        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"authorid", AuthorId},
                {"startposttime", StartPostTime},
                {"taxonomyid", TaxonomyId},
                {"title", Title},
                {"sort", Sort},
                {"endposttime", EndPostTime},
                {"fields", Fields},
                {"shopid", ShopId},
                {"status", Status},
                {"haspunish", HasPunish},
                {"tags", Tags},
                {"categoryname", CategoryName},
                {"companyid", CompanyId},
                {"customtype",CustomType }
            };
            return parameters;
        }

        public void Validate()
        {

        }

    }
}
