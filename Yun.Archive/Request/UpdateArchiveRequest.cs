using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    public class UpdateArchiveRequest : ITopUploadRequest<BoolResultResponse>, IUploadInEditState
    {
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

        public int Id { get; set; }

        /// <summary>
        /// 文章的缩略图
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 上传的图片
        /// </summary>
        public FileItem NewImage { get; set; }

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
        public int? Visits { get; set; }

        /// <summary>
        /// 发布时间,UNIX时间戳
        /// </summary>
        public long PostTime { get; set; }

        /// <summary>
        /// 自定义类型
        /// </summary>
        public int CustomType { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title", Title},
                {"detail", WebUtils.ToBase64StringForUrl(Detail)},
                {"categoryid", CategoryId},
                {"tags", Tags},
                {"id", Id},
                {"sort", Sort},
                {"image", Image},
                {"commentstatus", CommentStatus},
                {"password", Password},
                {"parentid", ParentId},
                {"postmeta", PostMeta},
                {"status",Status},
                {"visits",Visits},
                {"posttime",PostTime},
                {"customtype",CustomType }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateRequired("detail", Detail);
            RequestValidator.ValidateRequired("id", Id);
        }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "NewImage", NewImage } };
        }
    }
}
