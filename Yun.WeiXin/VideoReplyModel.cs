using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class VideoReplyModel
    {
        /// <summary>
        /// URL
        /// </summary>
        [XmlElement("media_id")]
        public string Url { get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        [XmlElement("title")]
        public string Text { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
