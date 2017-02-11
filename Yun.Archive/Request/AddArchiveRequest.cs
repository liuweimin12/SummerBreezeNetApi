using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class AddArchiveRequest : ITopUploadRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.archive.add";
        }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public double Sort { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        //评论状态
        public string CommentStatus { get; set; }

        /// <summary>
        /// 查看密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }


        /// <summary>
        ///文章的附属内容 
        /// key:value^key:value
        /// </summary>
        public string PostMeta { get; set; }

        /// <summary>
        /// 文章发布状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 浏览量
        /// </summary>
        public int Visits { get; set; }

        /// <summary>
        /// 发布时间,UNIX时间戳
        /// </summary>
        public long PostTime { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        public string Thumb { get; set; }

        /// <summary>
        /// 自定义类型
        /// </summary>
        public int CustomType { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        
        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title", Title},
                {"detail", WebUtils.ToBase64StringForUrl(Detail)},
                {"categoryid",CategoryId},
                {"tags",Tags},
                {"sort", Sort},
                {"commentstatus", CommentStatus},
                {"password", Password},
                {"parentid", ParentId},
                {"postmeta", PostMeta},
                {"status",Status},
                {"visits",Visits},
                {"posttime",PostTime},
                {"thumb",Thumb},
                {"customtype",CustomType },
                {"shopid",ShopId },
                {"companyid",CompanyId }
            };

            return parameters;
        }

        /// <summary>
        /// 文章的缩略图，可多张
        /// </summary>
        public FileItem Image { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateMaxLength("title", Title, 200);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem>
            {
                {"Image", Image}
            };
        }

    }
}
