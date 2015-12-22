using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_voice_replies_response")]
    public class GetVoiceRepliesResponse:YunResponse
    {
        [XmlElement("rule_detail")]
        public RuleDetail RuleDetail { get; set; }

        [XmlArray("voice_replies")]
        [XmlArrayItem("voice_reply")]
        public List<VoiceReplyModel> Replies { get; set; }
    }
}
