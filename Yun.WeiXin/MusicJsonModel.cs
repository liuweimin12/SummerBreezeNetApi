
namespace Yun.WeiXin
{
    public class MusicJsonModel
    {
        /// <summary>
        /// URL
        /// </summary>
        
        public string url { get; set; }

        /// <summary>
        /// 高品质URL
        /// </summary>
        public string hq_url { get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 缩略图的媒体ID
        /// </summary>
        public string thumb_media_id { get; set; }
    }
}
