using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    [XmlRoot("get_news_reply_response")]
    public class GetNewsRepliyResponse:YunResponse
    {
        [XmlElement("rule_detail")]
        public RuleDetail RuleDetail { get; set; }

        [XmlArray("news_replies")]
        [XmlArrayItem("news_reply")]
        public List<ImageTextReplyModel> Replies { get; set; }
    }
}
