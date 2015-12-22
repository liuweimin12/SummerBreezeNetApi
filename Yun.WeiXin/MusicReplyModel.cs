using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class MusicReplyModel
    {
        /// <summary>
        /// URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 高品质URL
        /// </summary>
        [XmlElement("hq_url")]
        public string HqUrl { get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 缩略图的媒体ID
        /// </summary>
        [XmlElement("thumb_media_id")]
        public string Thumb { get; set; }
    }
}
