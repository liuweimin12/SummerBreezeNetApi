using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class CompaniesResponse : YunResponse, IPageResponse
    {
        [XmlArray("companies")]
        [XmlArrayItem("company")]
        public List<Company> Companies { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
