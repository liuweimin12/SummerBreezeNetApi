using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    public class GetImageRulesResponse:YunResponse
    {
        [XmlArray("rules")]
        [XmlArrayItem("rule")]
        public List<RuleDomain> Rules { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
