using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
     [XmlRoot("get_distributors_history_response")]
    public class GetDistributorsHistoryResponse:YunResponse
    {
        [XmlArray("distribution_histories")]
        [XmlArrayItem("distribution_history")]
        public List<DistributionHistory> DistributionHistory { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
