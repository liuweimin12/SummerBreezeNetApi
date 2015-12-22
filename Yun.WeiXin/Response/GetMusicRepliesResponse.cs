using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_music_reply_response")]
    public class GetMusicRepliesResponse:YunResponse
    {
        [XmlElement("rule_detail")]
        public RuleDetail RuleDetail { get; set; }

        [XmlArray("music_replies")]
        [XmlArrayItem("music_reply")]
        public List<MusicReplyModel> Replies { get; set; }
    }
}
