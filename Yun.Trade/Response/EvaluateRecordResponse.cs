using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class EvaluateRecordResponse : YunResponse, IPageResponse
    {
        [XmlArray("evaluates")]
        [XmlArrayItem("evaluate")]
        public List<EvaluateRecord> Evaluates { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
