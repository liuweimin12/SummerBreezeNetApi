using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_image_reply_response")]
    public class GetImageResponse:YunResponse
    {
        [XmlElement("rule_detail")]
        public RuleDetail RuleDetail { get; set; }

        [XmlArray("image_replies")]
        [XmlArrayItem("image_reply")]
        public List<ImageReplyDomain> Reply { get; set; }
    }
}
