using System.Collections.Generic;
using System.Web;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 发布某文章的评论
    /// 需要授权
    /// </summary>
    public class AddArchiveCommentRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 用户代理
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// 父id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 文章id
        /// </summary>
        public int PostId { get; set; }

        public string GetApiName()
        {
            return "chenggou.archive.comment.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ip", Ip},
                {"content", HttpUtility.HtmlEncode(Content)},
                {"useragent",UserAgent},
                {"parentid",ParentId},
                {"postid", PostId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
            RequestValidator.ValidateRequired("ip", Ip);
            RequestValidator.ValidateRequired("postid", PostId);
        }
    }
}
