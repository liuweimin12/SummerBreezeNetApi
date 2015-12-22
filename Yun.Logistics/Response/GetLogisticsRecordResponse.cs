using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    [XmlRoot("get_logistics_record_response")]
    public class GetLogisticsRecordResponse : YunResponse
    {
        [XmlElement("logistics_information")]
        public LogisticsInformation LogisticsInformation { get; set; }
    }
}
