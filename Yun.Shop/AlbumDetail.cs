using System;

namespace Yun.Shop
{
    public class AlbumDetail
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 缩略图的完整URL
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 发布人用户名
        /// </summary>
        public string UserName { get; set; }
    }
}
