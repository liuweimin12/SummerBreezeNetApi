using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Private
{
    public class AppInfo
    {
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        [XmlElement("app_secret")]
        public string AppSecret { get; set; }
    }
}
