using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class KeywordType
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("content")]
        public string Content { get; set; }
    }
}
