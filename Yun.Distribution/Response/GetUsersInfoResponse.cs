using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Distribution.Response
{
    public class GetUsersInfoResponse : YunResponse
    {
        [XmlArray("distributors")]
        [XmlArrayItem("distributor")]
        public List<DistributionUser> Items { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
