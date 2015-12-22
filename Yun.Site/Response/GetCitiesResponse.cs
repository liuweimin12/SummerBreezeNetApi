using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_cities_response")]
    public class GetCitiesResponse:YunResponse
    {
        [XmlArray("cities")]
        [XmlArrayItem("city")]
        public List<CityDomain> Cities { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
