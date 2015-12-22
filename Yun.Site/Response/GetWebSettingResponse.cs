using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_websetting_response")]
    public class GetWebSettingResponse:YunResponse
    {
        [XmlArray("settings")]
        [XmlArrayItem("setting")]
        public List<YunKeyValuePair<string, string>> Settings { get; set; }
    }
}
