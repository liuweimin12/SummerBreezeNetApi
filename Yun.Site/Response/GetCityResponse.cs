using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_city_response")]
    public class GetCityResponse:YunResponse
    {
        [XmlElement("city")]
        public CityDomain City { get; set; }
    }
}
