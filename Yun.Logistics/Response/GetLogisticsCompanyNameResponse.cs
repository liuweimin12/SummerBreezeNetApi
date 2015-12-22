using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    [XmlRoot("get_logistics_company_name_response")]
    public class GetLogisticsCompanyNameResponse:YunResponse
    {
        [XmlArray("logistics_company_names")]
        [XmlArrayItem("logistics_company_name")]
        public List<LogisticsCompanyName> LogisticsCompanyNames { get; set; }
    }
}
