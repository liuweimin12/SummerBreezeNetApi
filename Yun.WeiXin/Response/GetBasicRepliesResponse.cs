using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_text_replies_response")]
    public class GetBasicRepliesResponse:YunResponse
    {
        [XmlElement("rule_detail")]
        public RuleDetail RuleDetail { get; set; }

        [XmlArray("text_replies")]
        [XmlArrayItem("text_reply")]
        public List<TextReplyDomain> Replies { get; set; }
    }
}
