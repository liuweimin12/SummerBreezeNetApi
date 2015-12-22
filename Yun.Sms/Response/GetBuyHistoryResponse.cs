using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class GetBuyHistoryResponse : YunResponse, IPageResponse
    {
        [XmlArray("trades")]
        [XmlArrayItem("trade")]
        public List<SmsBuyTrade> Result { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
