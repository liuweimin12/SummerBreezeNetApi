using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class GetSendHistoryResponse : YunResponse, IPageResponse
    {
        [XmlArray("histories")]
        [XmlArrayItem("history")]
        public List<SendHistory> Histories { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
