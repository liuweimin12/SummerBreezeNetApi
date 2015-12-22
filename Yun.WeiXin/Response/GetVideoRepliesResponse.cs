using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_video_replies_response")]
    public class GetVideoRepliesResponse:YunResponse
    {
        [XmlElement("rule_detail")]
        public RuleDetail RuleDetail { get; set; }

        [XmlArray("video_replies")]
        [XmlArrayItem("video_reply")]
        public List<VideoReplyModel> Replies { get; set; }
    }
}
