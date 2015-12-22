using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class TextReplyDomain
    {
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
