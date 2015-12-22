using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_operation_records_response")]
    public class GetOperationRecordsResponse:YunResponse
    {
        [XmlArray("records")]
        [XmlArrayItem("record")]
        public List<OperationRecord> Records { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
