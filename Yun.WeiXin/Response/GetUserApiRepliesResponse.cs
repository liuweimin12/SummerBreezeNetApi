using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_customapi_reply_response")]
    public class GetUserApiRepliesResponse:YunResponse
    {
        [XmlElement("rule_detail")]
        public RuleDetail RuleDetail { get; set; }


        [XmlElement("customapi_reply")]
        public CustomApiReplyModel Reply { get; set; }
    }
}
