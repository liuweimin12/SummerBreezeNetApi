using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public  class CustomApiReplyModel
    {
        [XmlElement("api_url")]
        public string ApiUrl { get; set; }

        [XmlElement("token")]
        public string Token { get; set; }

        [XmlElement("default_text")]
        public string DefaultText { get; set; }
    }
}
