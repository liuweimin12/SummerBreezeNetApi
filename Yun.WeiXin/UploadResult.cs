using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class UploadResult
    {
        [XmlElement("media_id")]
        public string MediaId { get; set; }

        [XmlElement("thumb_media_id")]
        public string ThumbMediaId { get; set; }

        [XmlElement("create_time")]
        public string CreateTime { get; set; }

    }
}
